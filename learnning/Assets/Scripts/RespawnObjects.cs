using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObjects : MonoBehaviour {

    public GameObject cube;
    private float timer = 0;
    float destTime = 0.5f;
    float decTime = 0.001f;
    float minDestTime = 0.2f;
    // Use this for initialization
    void Start ()
    {
        float r = Random.Range(-10, 10);
        Instantiate(cube, new Vector3(r, 1, 15), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer > destTime)
        {
           
            DecreaseTimer();
            int scale = Random.Range(1, 5);
            int numobs = 2;
            if(scale<3)
            {
                numobs = 4;
            }
            for (int i = 0; i < numobs; i++)
            {
                float r = Random.Range(-10, 10);

                cube.transform.localScale = new Vector3(scale, 1, 1);
                Instantiate(cube, new Vector3(r, 1, 15), Quaternion.identity);
            }
            timer = 0;
        }
    }
    void DecreaseTimer()
    {
        if((destTime-decTime)>minDestTime)
        {
            destTime -= decTime;
        }
    }
}
