#pragma strict
public static var CollectionFlags : boolean[] = new boolean[20];
public static var CollectionFlagsInts : int[] = new int[20];
public static var key : String = "PPAInts";
static var StartFlag : boolean = true;
var sum : int = 0;

function Start () {
    if (StartFlag == true) //図鑑の初期設定
    {
        for(var j = 0; j < CollectionFlags.Length; j++)
        {

        	CollectionFlagsInts[j] = PlayerPrefs.GetInt(key + j.ToString(),0);

        	if(CollectionFlagsInts[j] == 1)
        	{
        		CollectionFlags[j] =true;
        	}
        	else
        	{
        		CollectionFlags[j] =false;
        	}
		}
    }

    for(j = 0; j < CollectionFlags.Length; j++)
    {
        
        sum += CollectionFlagsInts[j] ;
    }
    if(sum == 20)
    {
        var go : GameObject = GameObject.Find("Button(Staffs)");
        go.GetComponent(Image).enabled = true;

    }
}