using UnityEngine;
using System.Collections;

public class ZombieBehaviorScript : MonoBehaviour {

	public int rotationoffset;
	public GameObject player;

	public float speed = 0.2f;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPos = new Vector3 (player.transform.position.x, player.transform.position.y, 0);
		targetPos = targetPos - transform.position;
		float angle = Mathf.Atan2 (targetPos.y, targetPos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle + rotationoffset, Vector3.forward);

		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, player.transform.position, step);


		// this.transform.position += targetPos - this.transform.position;
	}

	void FixedUpdate() {
		//this.GetComponent<Rigidbody2D> ().AddForce (transform.up * speed);
		//this.transform.position += 
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.name == "spriteBullet(Clone)") {
			Destroy (this.gameObject);
		}
	}
}
