using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cam : MonoBehaviour {
	private float offsetY;
	private Vector3 offset;
	public GameObject player;
	GameObject startWall;
	GameObject endWall;

	void Awake () {
			offset = transform.position - player.transform.position;
	}

	void Start(){
		startWall = GameObject.FindWithTag ("First Wall");
		endWall = GameObject.FindWithTag ("Last Wall");
		if(Open.way == 1)
		transform.position = new Vector3 (startWall.transform.position.x-1f, transform.position.y, transform.position.z);
		if(Open.way == -1)
		transform.position = new Vector3 (endWall.transform.position.x+1f, transform.position.y, transform.position.z);
	}

	void LateUpdate(){
		if (player.transform.position.x < endWall.transform.position.x + 3f && player.transform.position.x > startWall.transform.position.x + 1f )
			transform.position = new Vector3 (player.transform.position.x + offset.x, transform.position.y, transform.position.z);
		
		if (player.transform.position.x >= endWall.transform.position.x + 3f) {
			//transform.position = new Vector3 (transform.position.x - 0.001f, transform.position.y, transform.position.z);
			offset.x = transform.position.x - player.transform.position.x ;
		}

		if (transform.position.x <= startWall.transform.position.x + 1f) {
			//transform.position = new Vector3 (transform.position.x + 0.001f, transform.position.y, transform.position.z);
			offset.x = transform.position.x - player.transform.position.x ;
		}
	}
}
