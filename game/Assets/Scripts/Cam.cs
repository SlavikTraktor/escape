using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cam : MonoBehaviour {
	private float offsetY;
	private Vector3 offset;
	public GameObject player;

	void Start () {
		offset = transform.position - player.transform.position;
	}

	void LateUpdate(){
		transform.position = new Vector3(player.transform.position.x + offset.x,offset.y,player.transform.position.z + offset.z);

	}
}
