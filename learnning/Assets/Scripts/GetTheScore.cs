using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GetTheScore : MonoBehaviour {

    void Start()
    {
        string score = "";
        using (var reader = new BinaryReader(File.OpenRead("FileName")))
        {
            int a = reader.ReadChar();
            while (a > 0)
            {
                score += a;
                a = reader.ReadChar();
            }
        }
        Text t = gameObject.GetComponent<Text>();
        t.text = score;
        Debug.Log(score.ToString());
    }

    // Update is called once per frame
    void Update ()
    {
        

    }
}
