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
        Debug.Log(obsSpeed);
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
                Debug.Log(high+" "+score);
            }
            using (var writer = new BinaryWriter(File.OpenWrite("FileName")))
            {
                if(score>high)
                {
                    writer.Write(score);
                    Debug.Log("new high score");
                }
                writer.Close();
            }
            isOver = false;
            counter++;
        }
        
    }
}
