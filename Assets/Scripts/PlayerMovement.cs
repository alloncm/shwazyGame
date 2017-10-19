using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    Rigidbody Player;

    bool moveRight = false;
    bool moveLeft = false;

    public Vector3 move = new Vector3(15, 0, 0);

    // Use this for initialization
    void Start ()
    {
        Player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("left"))
        {
            moveLeft = true;
        }
        if(Input.GetKey("right"))
        {
            moveRight = true;
        }

        if(transform.position.y<0)
        {
            Restart();
        }
	}

    //fixed update for the phisycs calc
    void FixedUpdate()
    {
        //adding gravity of my own to the rigit body as the Gravity wasnt strong enough
        Player.AddForce(new Vector3(0, -100, 0),ForceMode.Force);
        Transform t = Player.transform;

        if (moveRight)
        {
            Player.MovePosition((t.position+move*Time.deltaTime));
            //Player.AddForce(move * Time.deltaTime, ForceMode.VelocityChange);
            moveRight = false;
        }
        if(moveLeft)
        {
           Player.MovePosition((t.position-move*Time.deltaTime));
           //Player.AddForce(-move * Time.deltaTime, ForceMode.VelocityChange);
            moveLeft = false;   
        }
    }
    void OnCollisionEnter( Collision collision )
    {
        if (collision.collider.tag == "Obstacle")
        {
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
