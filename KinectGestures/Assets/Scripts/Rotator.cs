using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	// Update is called once per frame
	//use update instead of fixed update because you are not using forces
	void Update () 
	{ 
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
