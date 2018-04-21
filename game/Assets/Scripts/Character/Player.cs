using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour {
	public static float speed = 10f;
	public static float JumpScale = 3000f;
	//public GameObject sl;
	public bool away = true;
	public GameObject L;
	public GameObject R;
	private bool sta,left,right;
	public static bool isHaveSecretKey;
	public static bool isHidden;
	//public Button but;

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Ground")
			away = true;
		if (other.gameObject.tag == "Walls") {
			if (L.GetComponent <forPanels> ().move == true && left == true) {
				right = false;
				transform.position = Vector3.MoveTowards (transform.position,transform.position + 
					new Vector3(1000f,0,0),Player.speed*Time.deltaTime);
				sta = false;
			}
			if (R.GetComponent <forPanels> ().move == true && right == true) {
				left = false;
				transform.position = Vector3.MoveTowards (transform.position,transform.position + 
					new Vector3(-1000f,0,0),Player.speed*Time.deltaTime);
				sta = true;
			}
			L.GetComponent <forPanels> ().move = false;
			R.GetComponent <forPanels> ().move = false;
			GetComponent<Animator> ().Play ("stay");
		}
		if (L.GetComponent <forPanels> ().move == true || R.GetComponent <forPanels> ().move == true)
			GetComponent<Animator> ().Play ("New Animation");
		else GetComponent<Animator> ().Play ("stay");
	}
		
//?

	void OnCollisionExit2D(Collision2D other) {
		if (other.gameObject.tag == "Ground") {
			away = false;
			//print ("test");
		}
	}

	void start() {
		isHaveSecretKey = false;
		isHidden = false;
	}
	
	void Update(){
		if (isHidden){
			L.GetComponent<Image> ().enabled = false;
			R.GetComponent<Image> ().enabled = false;
		}
		else{
			L.GetComponent<Image> ().enabled = true;
			R.GetComponent<Image> ().enabled = true;
		}
	}
}
