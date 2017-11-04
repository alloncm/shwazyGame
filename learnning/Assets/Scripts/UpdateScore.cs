using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateScore : MonoBehaviour {

    Text t;

    float score;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        score += Time.deltaTime;
        int s = (int)score;
        t.text = ""+s;
	}
}
