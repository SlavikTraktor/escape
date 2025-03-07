﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHide : MonoBehaviour {
	
	GameObject player;

	void Start () {
		player = GameObject.Find("Player");
	}
	
	void Update () {
		
	}

	void OnMouseDown() {
		if (transform.position.x + 7f >= player.transform.position.x 
		&& transform.position.x - 7f <= player.transform.position.x && !Player.isHidden) {
			player.transform.position = new Vector3(transform.position.x,player.transform.position.y, 16f); 
			Player.isHidden = true;
		} else if (Player.isHidden) {
			player.transform.position = new Vector3(transform.position.x,player.transform.position.y, 0f);
			Player.isHidden = false;
		}
	}
	
}
