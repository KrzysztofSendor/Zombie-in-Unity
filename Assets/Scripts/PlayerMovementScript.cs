using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	public float maxSpeed = 1f;

	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;

		pos.y += Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime;
		pos.x += Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime;

		transform.position = pos;
	}
}
