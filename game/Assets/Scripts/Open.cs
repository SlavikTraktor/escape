using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Open : MonoBehaviour {
	void Start(){
	}
	public void ChangeScene(){
		switch(gameObject.name){
		case "Start":
			SceneManager.LoadScene("first scene");
			break;
		case "Exit":
			Application.Quit();
			break;
			}

	}
}
