using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

	private float walkSpeed;
	private GameObject currentTarget;
	private Animator animator;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
		if (!currentTarget){
			Debug.Log("dead");
			animator.SetBool("isAttacking", false);
		}
	}
	
	void OnTriggerEnter2D(){
		//Debug.Log("Trigger " + name);
	}
	
	public void SetSpeed(float speed){
		walkSpeed = speed;
	}
	
	public void StrikeCurrentTarget(float damage){
		Debug.Log (name + " does " + damage + " damage");
		if (currentTarget){
			Health health = currentTarget.GetComponent<Health>();
			if (health){
				health.TakeDamage(damage);
			}
		}
	}
	
	public void Attack(GameObject defender){
		currentTarget = defender;
	}
}
