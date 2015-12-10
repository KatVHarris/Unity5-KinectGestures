using UnityEngine;
using System.Collections;

public class Turning : MonoBehaviour {
    public bool turnLeft;
    public bool turnRight;
    private bool rotating;
    public float rotatespeed = 2f;
	// Use this for initialization
	void Start () {
	
	}
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        if (turnRight)
    //        {
    //            turnRight = false;
    //            turnLeft = true;
    //        }
    //        else
    //        {
    //            turnLeft = true;
    //        }
    //    }
    //    if (Input.GetKeyDown(KeyCode.D))
    //    {
    //        if (turnLeft)
    //        {
    //            turnLeft = false;
    //            turnRight = true;
    //        }
    //        else
    //        {
    //            turnRight = true;
    //        }
    //    }
    //}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (turnLeft)
        {

            transform.Rotate(new Vector3(0, -20, 0) * Time.deltaTime);
            //transform.Rotate(Vector3.right * Time.deltaTime * rotatespeed);


        }
        if (turnRight)
        {
            transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime);
        }
    }
}

