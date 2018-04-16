using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonStart(){
		SceneManager.LoadScene (0);
	}

	public void ButtonLoad(){
		SceneManager.LoadScene (0);
	}

	public void ButtonExit(){
		Application.Quit();
	}


	public void ButtonSetting(){
		SceneManager.LoadScene (0);
	}
}
