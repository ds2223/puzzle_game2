using UnityEngine;
using System.Collections;

public class SaveDelete : MonoBehaviour {

	// Use this for initialization
	public void Delete () {
		PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
