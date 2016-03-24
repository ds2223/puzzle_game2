using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoads : MonoBehaviour {
	public void SceneLoadCollection()
	{
		//SceneManager.LoadScene("Collection");
        Application.LoadLevel("Collection");
    }
	public void SceneLoadMaim()
	{
		//SceneManager.LoadScene("Main");
        Application.LoadLevel("Main");
    }
}
