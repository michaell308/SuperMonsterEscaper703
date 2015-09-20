	void Start () {
		direction = Random.Range(0,3);
		float xPos = Random.Range(-9,10);
		xPos = xPos*5 + 2.5f;
		float yPos = Random.Range(-9,10);
		yPos = yPos *5;
		this.gameObject.transform.position = new Vector2(xPos,yPos);
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D right = Physics2D.Raycast(transform.position, transform.right, 1.5f, 1 << LayerMask.NameToLayer("Wall"));
		RaycastHit2D left = Physics2D.Raycast(transform.position, -transform.right, 1.5f, 1 << LayerMask.NameToLayer("Wall"));
		RaycastHit2D up = Physics2D.Raycast(transform.position, transform.up, 1.5f, 1 << LayerMask.NameToLayer("Wall"));
		RaycastHit2D down = Physics2D.Raycast(transform.position, -transform.up, 1.5f, 1 << LayerMask.NameToLayer("Wall"));
		if (direction == 0) {
			if(right){
				while (direction == 0) {
					direction = Random.Range(0,4);
				}
			}
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * enemySpeed, ForceMode2D.Impulse);
			GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
		}
		else if (direction == 1) {
			if(up){
				while (direction == 1) {
					direction = Random.Range(0,4);
				}
			}
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * enemySpeed, ForceMode2D.Impulse);
			GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
		}
		else if (direction == 2) {
			if(left){
				while (direction == 2) {
					direction = Random.Range(0,4);
				}
			}
	
			GetComponent<Rigidbody2D>().AddForce(-Vector2.right * enemySpeed, ForceMode2D.Impulse);
			GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
		}
		else if (direction == 3) {
			if(down){
				while (direction == 3) {
					direction = Random.Range(0,4);
				}
			}
			
			GetComponent<Rigidbody2D>().AddForce(Vector2.down * enemySpeed, ForceMode2D.Impulse);
			GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
		}

	}
	

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "SpeedUp" || other.gameObject.tag == "SlowDown" || other.gameObject.tag == "Teleport") {
			if (direction == 0) {
					while (direction == 0) {
						direction = Random.Range(0,4);
					}
				GetComponent<Rigidbody2D>().AddForce(Vector2.right * enemySpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
			}
			else if (direction == 1) {
					while (direction == 1) {
						direction = Random.Range(0,4);
					}
				
				GetComponent<Rigidbody2D>().AddForce(Vector2.up * enemySpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
			}
			else if (direction == 2) {
			
					while (direction == 2) {
						direction = Random.Range(0,4);
					}
				
				GetComponent<Rigidbody2D>().AddForce(-Vector2.right * enemySpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
			}
			else if (direction == 3) {
					while (direction == 3) {
						direction = Random.Range(0,4);
					}
				
				GetComponent<Rigidbody2D>().AddForce(Vector2.down * enemySpeed, ForceMode2D.Impulse);
				GetComponent<Rigidbody2D>().velocity = constantSpeed * (GetComponent<Rigidbody2D>().velocity.normalized);
			}
		}
	}
}
