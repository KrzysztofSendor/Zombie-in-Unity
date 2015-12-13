using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.name != "player") {
			Destroy (this.gameObject);
		}
	}
}
