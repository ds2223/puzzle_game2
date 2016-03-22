#pragma strict
import UnityEngine.UI;					//UIに関するスクリプトをインポートして使えるように

public class sei extends MonoBehaviour {

public var ballPrefab: GameObject;		//ボールのプレハブ
public var ballSprites: Sprite[];		//ボールの画像のリスト
 
private var firstBall: GameObject;		//はじめにドラッグしたボール
private var removableBallList: Array;	//消去するボールのリスト
private var lastBall: GameObject;		//直前にドラッグしたボール
private var currentName: String;		//現在リストにあるボールの名前(ボールの色)
 
private var isPlaying = false;			//プレイ中かどうか
 
public var timer: GameObject;			//タイマーとなるオブジェクト
private var timerText: Text;			//タイマーのテキスト
private var timeLimit = 60;				//制限時間
private var countTime = 3;				//カウントダウンの秒数
 
public var score: GameObject;			//スコア表示
private var scoreText: Text;			//スコア表示のテキスト
private var currentScore = 0;			//現在のスコア

public var myClip : AudioClip;			//SE用の音楽オブジェクト


function Start() {
	timerText = timer.GetComponent(Text); //タイマーを取得
	scoreText = score.GetComponent(Text); //scoreTextを設定
	CountDown();							//カウントダウン開始
	DropBall(55);
}
 
function Update() {
	if (isPlaying) {
		if (Input.GetMouseButton(0) && firstBall == null) {
			OnDragStart(); 				//ボールをドラッグしはじめたとき
		}
		else if (Input.GetMouseButtonUp(0)) {
			OnDragEnd(); 				//ボールをドラッグし終わったとき
		}
		else if (firstBall != null) {
			OnDragging(); 				//ボールをドラッグしている途中
		}
	}

scoreText.text = "Score:" + currentScore; //現在のスコアを表示
}


private function OnDragStart() {
var col = GetCurrentHitCollider(); 		//現在マウスカーソルの位置にあるオブジェクト
	if (col != null) {					//なにかをドラッグしているとき
	GetComponent.<AudioSource>().PlayOneShot(myClip);//カチカチ音がする
		var colObj = col.gameObject;
		if (colObj.name.IndexOf("Ball") != -1) {//名前に"Ball"を含むオブジェクトをドラッグしたとき
			removableBallList = new Array(); 	//消去するボールのリストを初期化
			firstBall = colObj; 				//はじめにドラッグしたボールを現在のボールを設定
			currentName = colObj.name; 			//現在のリストのボール名前(色)を設定
			PushToList(colObj); 				//消去するリストにボールを追加
		}
	}
}
private function OnDragEnd() {
	if (firstBall != null) {										//1つ以上のボールをなぞっているとき
		var length = removableBallList.length;
		if (length >= 3) {											//消去するリストに３個以上ボールがあれば（ボールが三個以上つながっていたら
			for (var i = 0; i < length; i++) {
				var t : GameObject = removableBallList[i];			//tにゲームオブジェクト付加
				
				var go = Resources.Load("Prefab/explosion") as GameObject;//アセットのオブジェクトにアクセス
				Instantiate(go,t.transform.position,Quaternion.identity);//爆発のエフェクト
				if(length == 4){
					Instantiate(Resources.Load("Prefab/thunder"), new Vector2(0,0), Quaternion.identity);
				}
				if(length >= 5){
					Instantiate(Resources.Load("Prefab/flame"), new Vector2(0,0), Quaternion.identity);
				}
				
				Destroy(removableBallList[i]); 						//リストにあるボールを消去

			}
			currentScore += (CalculateBaseScore(length) + 50 * length);
			
			DropBall(length);
		}
		else {									//消去するリストに3個以上ボールがないとき
			for (var j = 0; j < length; j++) {
				var listedBall: GameObject = removableBallList[j];
				ChangeColor(listedBall, 1.0);
				listedBall.name = listedBall.name.Substring(1, 5); //Ballの名前を元に戻す
			}
		}
	firstBall = null; //変数の初期化
	}
}

private function OnDragging() {
var col = GetCurrentHitCollider();
	if (col != null) {						//なにかをドラッグしているとき
	var colObj = col.gameObject;
		if (colObj.name == currentName) {	//現在リストに追加している色と同じ色のボールのとき
		GetComponent.<AudioSource>().PlayOneShot(myClip);//カチカチ音がする
			if (lastBall != colObj) {		//直前にリストにいれたのと異なるボールのとき
				var dist = Vector2.Distance(lastBall.transform.position, colObj.transform.position);
				if (dist <= 1.5) {			//ボール間の距離が一定値以下のとき
					PushToList(colObj); 	//消去するリストにボールを追加
				}
			}
		}
	}
}
 
function PushToList(obj: GameObject) {
	lastBall = obj; 						//直前にドラッグしたボールに現在のボールを追加
	ChangeColor(obj, 0.5); 
	removableBallList.push(obj); 			//消去するボールのリストに現在のボールを追加
	obj.name = "_" + obj.name; 				//区別のため、消去するボールのリストに加えたボールの名前を変更
}
 
private function CountDown() {
	var count = countTime;
	while (count > 0) {
		timerText.text = count.ToString(); 	//カウントダウンのテキストを変更
		yield WaitForSeconds(1); 			//1秒待つ
		count -= 1; 						//カウントを1つ減らす
	}
	timerText.text = "Start!";
	isPlaying = true;
	yield WaitForSeconds(1);
	StartTimer(); 							//制限時間のカウントを開始
}
 
private function StartTimer() {
	var count = timeLimit;
	while (count > 0) {
		timerText.text = count.ToString();
		yield WaitForSeconds(1);
		count -= 1;
	}
	timerText.text = "Finish";
	OnDragEnd();
	isPlaying = false;
}
 
private function GetCurrentHitCollider() {
	var hit: RaycastHit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
	return hit.collider;
}
 
private function ChangeColor(obj: GameObject, transparency: float) {
	var ballTexture = obj.GetComponent(SpriteRenderer); //ボールの画像を管理している要素を取得
	ballTexture.color.a = transparency; 				//透明度を設定
}

function CalculateBaseScore(n: int){
  var tempScore = 50* n *(n+1) -300;
  return tempScore;
}
 
private function DropBall(count: int) {
	for (var i = 0; i < count; i++) {
		var ball = Instantiate(ballPrefab); 					//ボールのプレハブを読み込み
		ball.transform.position.x = Random.Range(-2.0, 2.0); 	//ボールのｘ座標をランダムに設定
		ball.transform.position.y = 7; 							//ボールのｙ座標を調整
		ball.transform.eulerAngles.z = Random.Range(-40, 40); 	//ボールの角度をランダムに設定
		var spriteId: int = Random.Range(0, 5); 				//ボールの画像のid(ボールの色)をランダムに設定
		ball.name = "Ball" + spriteId; 							//ボールの名前を画像のidに合わせ変更
		var ballTexture = ball.GetComponent(SpriteRenderer); 	//ボールの画像を管理している要素を取得
		ballTexture.sprite = ballSprites[spriteId]; 			//ボールの画像をidに合わせて変更
		yield WaitForSeconds(0.05); 							//次のボールを生成するまで一定時間待つ
	}
}
}