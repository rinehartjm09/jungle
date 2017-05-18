using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	public float playerSpeed = 1.0f;
	public float playerJump = 10.0f;
	private bool onGround = true;


	// Use this for initialization
	void Start () {
	}
		
	// Update is called once per frame
	void FixedUpdate () {
//				onGround = true;
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (-playerSpeed * Time.smoothDeltaTime, 0, 0);
	}
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Translate (playerSpeed * Time.smoothDeltaTime, 0, 0);
		}
//		if (Input.GetKey(KeyCode.UpArrow)){
//			transform.Translate (0, playerSpeed * Time.smoothDeltaTime, 0);
//		}
//		if (Input.GetKey(KeyCode.DownArrow)){
//			transform.Translate (0, -playerSpeed * Time.smoothDeltaTime, 0);
//		}
		Rigidbody2D player = GetComponent<Rigidbody2D> ();
		if (Input.GetKeyDown(KeyCode.Space) && onGround){
			player.AddForce (Vector2.up * playerJump);
//			onGround = false; 
		}

}
}