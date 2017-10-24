using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWall : MonoBehaviour {

    public Transform cube;
	// Use this for initialization
	void Start ()
    {
        Vector3 pos = new Vector3(0, 50, 0);
        Instantiate(cube, pos,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
