using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {


    public GameObject Player;

    public Vector3 offset = new Vector3(0, 2, -6);
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Player.transform.position;
        transform.position += offset;
    }
}
