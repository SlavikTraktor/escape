using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Open : MonoBehaviour {
	public int index;
	public static GameObject player;
	public static int way = 1;

	void Start(){
		player = GameObject.Find("Player");
	}

	public void OnMouseDown(){
		if (transform.position.x + 7f >= player.transform.position.x
		    && transform.position.x - 7f <= player.transform.position.x) {
			if (this.tag == "Enter Doors") {
				SceneManager.LoadScene (index);
				way = -1;
			} else if (this.tag == "Exit Doors") {
				SceneManager.LoadScene (index);
				way = 1;
			}

		}
	}
		
}