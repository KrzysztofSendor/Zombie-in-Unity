using UnityEngine;
using System.Collections;

public class PlayerShootingScript : MonoBehaviour {

	public Rigidbody2D bullet;
	public float bulletSpeed = 2500;
	public float attackSpeed = 0.5f;
	public float coolDown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= coolDown) {
			if(Input.GetMouseButton(0)){
				Fire();
			}
		}
	}

	void Fire() {
		Rigidbody2D prefab = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody2D;
		prefab.GetComponent<Rigidbody2D>().AddForce (transform.up * bulletSpeed);
		coolDown = Time.time + attackSpeed;
		//prefab.GetComponent<BoxCollider2D>().isTrigger = false;
	}
}
