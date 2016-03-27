#pragma strict
class serif extends MonoBehaviour {
    public var hp = 100;
    public var EnemyHP: GameObject;
    private var enemyHp : Text;
    
    function Start () {
        enemyHp =EnemyHP.GetComponent(Text);
    }

        function Update () {
            
            message();
            GameClear();
            Time();
        }

        function Conbat(){
            var score : int;
            score = sei.currentScore;
            if (score > hp) {
                GameClear();
            }
        }

        function message(){
            var score : int;
            score = sei.currentScore;
            //体力が半分になったら
            if(score > (hp/2)){
                enemyHp.text = "もうすぐ食べられる";           
            }
        }

        function GameClear(){
        	var score : int;
            score = sei.currentScore;
            //体力がなくなったら
            if(score > hp){
                enemyHp.text = "食べごろ";           
            }
        }
        
        function Time(){
	        var time : int;
	        time = sei.timeLimit;
	        //タイムアップしたら
	        if(time < 0){
	        enemyHp.text = "タイムアップ";  
	        }
	    }
    }
