using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private float playerSpeed = 13.0f;
	public static float constantSpeed = 13.0f;
	private bool goingRight;
	private bool goingLeft;
	private bool goingUp;
	private bool goingDown;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D)) {
			if (!goingLeft && !goingUp && !goingDown) {
				GetComponent<Rigidbody2D>().AddForce(Vector2.right * playerSpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				//set direction player is currently going
				goingRight = true;
				goingLeft = false;
				goingUp = false;
				goingDown = false;
			}
		}
		if (Input.GetKey(KeyCode.A)) {
			if (!goingRight && !goingUp && !goingDown) {
				GetComponent<Rigidbody2D>().AddForce(-Vector2.right * playerSpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				//set direction player is currently going
				goingLeft = true;
				goingRight = false;
				goingUp = false;
				goingDown = false;
			}
		}
		if (Input.GetKey(KeyCode.W)) {
			if (!goingLeft && !goingRight && !goingDown) {
				GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerSpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				//set direction player is currently going
				goingUp = true;
				goingLeft = false;
				goingRight = false;
				goingDown = false;
			}
		}
		if (Input.GetKey(KeyCode.S)) {
			if (!goingLeft && !goingUp && !goingRight) {
				GetComponent<Rigidbody2D>().AddForce(-Vector2.up * playerSpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				//set direction player is currently going
				goingDown = true;
				goingLeft = false;
				goingUp = false;
				goingRight = false;
			}


		}

		if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)) {
			if (!goingLeft && !goingDown) {
				GetComponent<Rigidbody2D>().AddForce((Vector2.right+Vector2.up) * playerSpeed * 2);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				goingRight = true;
				goingUp = true;
				goingLeft = false;
				goingDown = false;
			}
		}
		if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) {
			if (!goingLeft && !goingUp) {
				GetComponent<Rigidbody2D>().AddForce((Vector2.right-Vector2.up) * playerSpeed *2);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				goingRight = true;
				goingDown = true;
				goingLeft = false;
				goingUp = false;
			}
		}
		if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) {
			if (!goingRight && !goingDown) {
				GetComponent<Rigidbody2D>().AddForce((-Vector2.right+Vector2.up) * playerSpeed * 2);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				goingLeft = true;
				goingUp = true;
				goingRight = false;
				goingDown = false;
			}
		}
		if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)) {
			if (!goingRight && !goingUp) {
				GetComponent<Rigidbody2D>().AddForce((-Vector2.right-Vector2.up) * playerSpeed * 2);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
				goingLeft = true;
				goingDown = true;
				goingRight = false;
				goingUp = false;
			}
		}


		if (Input.GetKeyUp(KeyCode.D)) {
			goingRight = false;
		}
		if (Input.GetKeyUp(KeyCode.A)) {
			goingLeft = false;
		}
		if (Input.GetKeyUp(KeyCode.W)) {
			goingUp = false;
		}
		if (Input.GetKeyUp(KeyCode.S)) {
			goingDown = false;
		}// 
		if (!goingRight && !goingLeft && !goingUp && !goingDown) {
			//STOP MOVEMENT
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.gameObject.tag == "SpeedUp") {
			constantSpeed += 7f;
		}
		if (other.gameObject.tag == "SlowDown") {
			constantSpeed -= 5f;
		}
		if (other.gameObject.tag == "Enemy") {
			Application.LoadLevel("LoseScreen");
		}
	}
}
