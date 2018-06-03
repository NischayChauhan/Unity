using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public Text count;
	public Text decision;
	private int c;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		c = 0;
		setCountText();
	}
	
	// Update is called once per frame
	void Update () {
		float f=Input.GetAxis("Horizontal");
		float b=Input.GetAxis("Vertical");
		
		Vector3 mov= new Vector3(f,0.0f,b);
		rb.AddForce(mov * speed);	

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Points"))
        {
        	other.gameObject.SetActive(false);
        }
        c = c + 1;
    	setCountText();    
	}
	void setCountText(){
		count.text = "Count :" + c;
		if(c == 26){
			decision.text = "WIN";
		}
	}
	
}
