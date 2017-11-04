using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    
    Vector3 speed = new Vector3(0, 0, -15);

    public Vector3 localSpeed;
	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().AddForce(speed * Time.deltaTime, ForceMode.VelocityChange);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(transform.position.y<0)
        {
            Destroy(gameObject);
        }
        GameObject gm = GameObject.FindWithTag("GameController");
        localSpeed = gm.GetComponent<GameManager>().GetObsSpeed();
	}
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(localSpeed*Time.deltaTime,ForceMode.VelocityChange);
    }
}
