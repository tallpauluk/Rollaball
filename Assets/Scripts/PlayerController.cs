﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10.0f;
	private int count = 0;
	public GUIText countText;
	// Use this for initialization
	void Start () {
		UpdateCount();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce (movement*speed*Time.deltaTime);
	}
	void OnTriggerEnter(Collider other){
		 if (other.gameObject.tag == "Pickup") {
			other.gameObject.SetActive(false);
			count++;
			UpdateCount();
		}
	}

	void UpdateCount() {
		countText.text = count.ToString();
	}
}
