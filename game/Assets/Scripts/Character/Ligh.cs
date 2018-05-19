using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ligh : MonoBehaviour {

	private float offsetY;
	private Vector3 offset;
	public GameObject player;
	void Start () {
		player = GameObject.Find("Player");
		offset = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y, offset.z);
	}
}
