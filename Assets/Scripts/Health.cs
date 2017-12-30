using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health = 100f;
	
	public void TakeDamage(float damage){
		health -= damage;
		if (health <= 0){
			// Play death animation
			KillObject();
		}
	}
	
	public void KillObject(){
		Destroy(gameObject);
	}
}
