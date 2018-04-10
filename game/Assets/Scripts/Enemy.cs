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
			transform.localScale = new Vector2((-1) * transform.localScale.y, transform.localScale.y);
		} else if (transform.position.x == min) {
			target = max;
			transform.localScale = new Vector2(transform.localScale.y, transform.localScale.y);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.name == "Player" && !Player.isHidden) {
			Debug.Log("You are gay");
		} 
	}
}