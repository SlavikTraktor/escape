using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float min, max, speed;
	private float target;

	void Start () {
		target = max;
	}
	
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position, 
		new Vector2(target, transform.position.y), speed*Time.deltaTime);

		if (transform.position.x == max) {
			target = min;
		} else if (transform.position.x == min) {
			target = max;
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.name == "Player") {
			Debug.Log("You are gay");
		}
	}
}