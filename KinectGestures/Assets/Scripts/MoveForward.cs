using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveForward : MonoBehaviour
{
 	public float forwardspeed = 2.0f;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    // Use this for initialization 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
    }


    
 	// Update is called once per frame 
 	void Update()
    {
       
              transform.Translate(Vector3.forward * Time.deltaTime * forwardspeed);
    }
    void FixedUpdate()
    {
        //rb.velocity = transform.TransformDirection(Vector3.forward  * forwardspeed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false); //deactivates the game object
            count = count + 1;
            setCountText();
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
