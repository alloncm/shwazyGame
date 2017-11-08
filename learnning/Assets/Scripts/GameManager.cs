using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{

    float timer = 0;
    float timeIncSpeed = 3;
    float incSpeed = -0.1f;

    public Vector3 obsSpeed;

    float ScoreTime = 0.0f;


	// Use this for initialization
	void Start ()
    {
        obsSpeed = new Vector3(0, 0, -15);
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (timer > timeIncSpeed)
        {
            timer = 0;
            obsSpeed.z += incSpeed;
        }
        else
        {
            timer += Time.deltaTime;
        }
        ScoreTime += Time.deltaTime;
    }
    public Vector3 GetObsSpeed()
    {
        return obsSpeed;    
    }

   
    void SaveCurrentScore(double score)
    {
        StreamWriter wr = new StreamWriter(@"Assets\TextFiles\score.txt");
        wr.WriteLine(score.ToString("0.0"));
        wr.Close();
        wr.Dispose();
    }
}
