using UnityEngine;
using System.Collections;

public class ZombieSpawnScript : MonoBehaviour {

	public Rigidbody2D zombie;

	public GameObject player;
	public int spawnSpeed = 6;
	public float coolDown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position;

		if (Time.time >= coolDown) {
			Spawn();
			coolDown = Time.time + spawnSpeed;
			if(spawnSpeed > 2){
				spawnSpeed = spawnSpeed - 1;
			}
		}
	}

	void Spawn() {
		for (int i=0; i<8; i++) {
			Rigidbody2D prefab = Instantiate (zombie, transform.position, transform.rotation) as Rigidbody2D;
			Vector3 pos = prefab.transform.position;

			if(i == 0) pos.x = pos.x - 100;
			else if(i == 1) pos.x = pos.x + 100;
			else if(i == 2) pos.y = pos.y - 100;
			else if(i == 3) pos.y = pos.y + 100;
			else if(i == 4) {
				pos.x = pos.x - 100;
				pos.y = pos.y - 100;
			}
			else if(i == 5) {
				pos.x = pos.x + 100;
				pos.y = pos.y + 100;
			}
			else if(i == 6) {
				pos.x = pos.x - 100;
				pos.y = pos.y + 100;
			}
			else if(i == 7) {
				pos.x = pos.x + 100;
				pos.y = pos.y - 100;
			}

			prefab.transform.position = pos;
		}
	}
}
