using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; //if public, you can make all the changes in the editor
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		setCountText ();
		winText.text = "";

	
	}


	void FixedUpdate ()
	{ //use command + a single quote to open an internet tab and search


		float moveHorizontal = Input.GetAxis ("Horizontal"); //controlled by the keys on the keyboard
		float moveVertical = Input.GetAxis ("Vertical");

        

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive(false); //deactivates the game object
			count = count + 1;
			setCountText ();
			if (count >= 6)
			{
				winText.text = "You win!";
			}

		}
	}

	void setCountText()
	{
		countText.text = "Count: " + count.ToString();
	}

}

//Destroy(other.gameObject);
//if (other.gameObject.CompareTag("Player"))
//	gameObject.setActive(false);