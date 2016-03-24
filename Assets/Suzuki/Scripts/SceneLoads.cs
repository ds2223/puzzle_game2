using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoads : MonoBehaviour {
	public void SceneLoadCollection()
	{
		SceneManager.LoadScene("Collection");
	}
	public void SceneLoadMaim()
	{
		SceneManager.LoadScene("Main");
	}
}
