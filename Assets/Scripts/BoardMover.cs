using UnityEngine;
using System.Collections;

public class BoardMover : MonoBehaviour {
	public float speed = 0.001f;
	private float zRot = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//zRot= zRot+ speed;
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		transform.Rotate(moveVertical,0,moveHorizontal*-1);
	}
}
