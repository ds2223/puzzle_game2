using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonPush()
    {
        Application.LoadLevel("Title");
        audioSource.Play();
    }

    public void ButtonTutorial()
    {       
        Application.LoadLevel("tutorial");
        audioSource.Play();
    }

    public void ButtonBook()
    {
        Application.LoadLevel("Collection");
        audioSource.Play();
    }

    public void ButtonMain()
    {
        Application.LoadLevel("Main");
        audioSource.Play();
    }
}

