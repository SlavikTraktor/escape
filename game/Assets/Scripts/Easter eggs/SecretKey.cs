using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecretKey : MonoBehaviour {

	private GameObject player;

	void Start () {
		player = GameObject.Find("Player");
	}

	public void OnMouseDown () {
		if (transform.position.x + 3f >= player.transform.position.x 
		&& transform.position.x - 3f <= player.transform.position.x) {
			Player.isHaveSecretKey = true;
			Destroy(this.gameObject);
		}
	}
}
