using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecretDoor : MonoBehaviour {

	//Сюда передаем номер сцены
	public int index = -1;

	public void OnMouseDown () {
		if (Player.isHaveSecretKey) {
			SceneManager.LoadScene(index);
		}
	}	
}
