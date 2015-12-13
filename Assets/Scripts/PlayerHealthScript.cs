using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealthScript : MonoBehaviour {

	public int startingHealth = 20;

	public int currentHealth;
	public Slider healthSlider;
	public Image gameOverImage;
	public Text gameOverText;

	public bool isDead = false;

	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;

		Color c = gameOverImage.color;
		c.a = 0;
		gameOverImage.color = c;

		c = gameOverText.material.color;
		c.a = 0;
		gameOverText.color = c;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.name == "spriteZombie(Clone)") {
			currentHealth -= 1;
			healthSlider.value = currentHealth;
			if(currentHealth <= 0 && !isDead){
				Death();
			}
		}
	}	

	void Death(){
		isDead = true;

		Color c = gameOverImage.color;
		c.a = 1;
		gameOverImage.color = c;

		c = gameOverText.material.color;
		c.a = 1;
		gameOverText.color = c;
	}
}
