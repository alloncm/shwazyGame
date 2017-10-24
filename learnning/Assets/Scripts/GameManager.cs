using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    float timer = 0;
    float timeIncSpeed = 3;
    float incSpeed = -0.1f;

    public Vector3 obsSpeed;

    GUIText text;

    float ScoreTime = 0.0f;
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
    }
}
