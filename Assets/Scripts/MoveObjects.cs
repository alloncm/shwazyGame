using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour {


    public Vector3 speed = new Vector3(0, 0, 10);
	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().AddForce(speed * Time.deltaTime, ForceMode.VelocityChange);
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y<0)
        {
            Destroy(gameObject);
        }
		
	}
    void FixedUpdate()
    {
        //GetComponent<Rigidbody>().MovePosition(transform.position + speed*Time.deltaTime);
        GetComponent<Rigidbody>().AddForce(speed*Time.deltaTime,ForceMode.VelocityChange);
    }
}
