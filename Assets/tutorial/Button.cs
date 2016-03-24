using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonPush()
    {
        Application.LoadLevel("Title");
    }

    public void ButtonTutorial()
    {       
        Application.LoadLevel("tutorial");
    }

    public void ButtonBook()
    {
        Application.LoadLevel("Collection");
    }

    public void ButtonMain()
    {
        Application.LoadLevel("Main");
    }
}

