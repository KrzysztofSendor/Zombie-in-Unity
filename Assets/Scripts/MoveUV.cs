using UnityEngine;
using System.Collections;

public class MoveUV : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MeshRenderer mr = GetComponent<MeshRenderer> ();

		Material mat = mr.material;

		Vector2 offset = mat.mainTextureOffset;

		offset.x = player.transform.position.x / transform.localScale.x;
		offset.y = player.transform.position.y / transform.localScale.y;

		mat.mainTextureOffset = offset;

		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, 0);;
	}
}
