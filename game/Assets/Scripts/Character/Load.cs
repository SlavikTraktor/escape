using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {
    GameObject door2;
	// Use this for initialization
	void Awake () {
		door2 = GameObject.FindWithTag ("Exit Doors");
		if (Open.way == -1)
			transform.position = new Vector3(door2.transform.position.x,door2.transform.position.y,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
