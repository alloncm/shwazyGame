using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {


    Text showScore;

    double score;
	// Use this for initialization
	void Start () {
        showScore = GetComponent<Text>();
        score = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        score += Time.deltaTime;
        int s = (int)score;
        showScore.text = ""+s;
	}
}
