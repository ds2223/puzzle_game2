using UnityEngine;
using System.Collections;


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
    public void SceneLoadStaffsPtage()
    {
        //SceneManager.LoadScene("StaffsPage");
        Application.LoadLevel("StaffsPage");
    }
}
