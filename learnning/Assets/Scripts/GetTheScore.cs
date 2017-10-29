using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GetTheScore : MonoBehaviour
{

    void Start()
    {
        string score = "";
        var reader = new StreamReader(@"Assets\TextFiles\score.txt");
        score = reader.ReadLine();
        Text t = gameObject.GetComponent<Text>();
        t.text = "Your Score Is " + score;
        reader.Close();
        reader.Dispose();

        //messing with the high score feature
        var highReader = new StreamReader(@"Assets\TextFiles\high.txt");
        if (highReader.EndOfStream)
        {
            highReader.Close();
            highReader.Dispose();
            var wr = new StreamWriter(@"Assets\TextFiles\high.txt");
            wr.WriteLine(score);
            Debug.Log("reached eof " + score);
            wr.Close();
            wr.Dispose();
        }
        else
        {
            double s = System.Convert.ToDouble(score);
            double high = System.Convert.ToDouble(highReader.ReadLine());
            if (s > high)
            {
                highReader.Close();
                highReader.Dispose();
                var wr = new StreamWriter(@"Assets\TextFiles\high.txt");
                wr.WriteLine(score);
                Debug.Log("reached writing to the high.txt " + score);
                wr.Close();
                wr.Dispose();
                t.text += "\nNew High Score";
            }
        }
    }

}
