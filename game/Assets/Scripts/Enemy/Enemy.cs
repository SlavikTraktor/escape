using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float min, max, speed;
	private float target;
	public Vector3 playerTarg;
	public Vector3 trig = new Vector3(10f,0f,0f);
	GameObject player;
	public float obstacleRange = 5.0f;

	void Start () {
		player = GameObject.Find("Player");
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
}