using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class changeScene : MonoBehaviour {

    public Text highText;
    public Text lastText;
	// Update is called once per frame
	public void ChangeToScenen (int scene)
    {
        SceneManager.LoadScene(scene);
    }   

    public void ViewHighScore()
    {
        string msg = "";
        var reader = new StreamReader(@"Assets\TextFiles\high.txt");
        if (reader.EndOfStream)
        {
            msg += "you have to play before you can have a high score dumd ass";
        }
        else
        {
            msg += reader.ReadLine();
        }
        highText.text = msg;
    }

    public void ViewLastScore()
    {
        string msg = "";
        var reader = new StreamReader(@"Assets\TextFiles\score.txt");
        if (reader.EndOfStream)
        {
            msg += "you have to play before you can have a last score dumd ass";
        }
        else
        {
            msg += reader.ReadLine();
        }
       lastText.text = msg;
    }
}
