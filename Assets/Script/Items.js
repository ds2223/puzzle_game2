#pragma strict
public static var CollectionFlags : boolean[] = new boolean[20];
static var StartFlag : boolean = true;
function Start () {
        if (StartFlag == true) //図鑑の初期設定
        {
            for (var i = 0; i < CollectionFlags.Length; i++)
            {
                CollectionFlags[i] = false;
                StartFlag = false;
            }
        }
}

function Update () {

}