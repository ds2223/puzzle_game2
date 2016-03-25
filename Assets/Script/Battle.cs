using UnityEngine;
using System.Collections;

public class Battle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void combat()
    {
        if (0 > 100)
        {
            GameClear();
        }
    }

    public void GameClear()
    {
        Debug.Log("ゲームクリア");
    }
}
