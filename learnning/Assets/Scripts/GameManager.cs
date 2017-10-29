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

    GUIText text;

    float ScoreTime = 0.0f;

    int counter = 0;
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
        UpdateGui();
    }
    public Vector3 GetObsSpeed()
    {
        return obsSpeed;    
    }

    public void UpdateGui()
    {
        SaveCurrentScore(ScoreTime);
        text = GetComponent<GUIText>();
        text.text = ((ScoreTime)).ToString("0.0");
        bool isOver = false;
        if(counter==0)
        {
            GameObject gm = GameObject.FindWithTag("Player");
            isOver = gm.GetComponent<PlayerMovement>().IsGameOver();
        }

        //managed to save high score
        if (isOver)
        {
            
            double score = ScoreTime;
            
            double high = 0;
            using (var reader = new BinaryReader(File.OpenRead("FileName")))
            {
                high = reader.ReadDouble();
               
            }
            using (var writer = new BinaryWriter(File.OpenWrite("FileName")))
            {
                if(score>high)
                {
                    writer.Write(score);
                    
                }
                writer.Close();
                
            }
            isOver = false;
            counter++;
        }
        
    }
    void SaveCurrentScore(double score)
    {
        using (var writer = new BinaryWriter(File.OpenWrite("CurScore.bin")))
        {
            writer.Write(score.ToString("0.0"));
            Debug.Log(score.ToString("0.0"));
            writer.Close();
        }
    }
}
