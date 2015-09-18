using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float xPos = Random.Range(-9,10);
		xPos = xPos*5 + 2.5f;
		float yPos = Random.Range(-9,10);
		yPos = yPos *5;
		this.gameObject.transform.position = new Vector2(xPos,yPos);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
}
