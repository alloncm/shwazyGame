using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	
	
	// Update is called once per frame
	public void ChangeToScenen (int scene)
    {
        SceneManager.LoadScene(scene);
    }   
}
