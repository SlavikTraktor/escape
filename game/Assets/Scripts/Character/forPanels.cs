using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class forPanels : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IBeginDragHandler,IDragHandler{
	public GameObject player; //person
	private Rigidbody2D rb; // rb for person
	public int count; //
	public bool move;
	public static bool useSwap = true;
	Coroutine coroutine = null;
	public GameObject LPanel;
	public GameObject RPanel;

	///////////////////////////////////////////////////////////////////////////Swap
	public void OnBeginDrag(PointerEventData eventData){
		if (useSwap == true) {
			move = false;
			if (eventData.delta.y > 0) {
				rb.AddForce (rb.transform.up * Player.JumpScale, ForceMode2D.Impulse);
				useSwap = false;
				player.transform.localScale =  new Vector2 (rb.transform.localScale.x, 6f);
				player.GetComponent <Animator> ().Play ("Jump");
			} 
			if (eventData.delta.y < 0) {
				player.transform.localScale =  new Vector2 (rb.transform.localScale.x, 1.4f);
			} 

		}
		if(player.GetComponent<Player>().away == true)
			useSwap = false;
		move = true;
	}

	public void OnDrag(PointerEventData eventData){
	}	

	/////////////////////////////////////////////////////////////////////////Game
	void Start () {
		rb = player.GetComponent <Rigidbody2D>();
		player.GetComponent <Animator> ().Play ("stay");
	}


	void Update () {
		if(coroutine == null)
		{
			coroutine = StartCoroutine(trsy());
		}

	}

	/////////////////////////////////////////////////////////////////////////touch
	public void OnPointerDown (PointerEventData eventData) {
		if (!Player.isHidden) {
			if (count == 1) {
				rb.transform.rotation = Quaternion.Euler (0, 0, 0);	
				RPanel.GetComponent<Image> ().enabled = false;
			} 
			else {
					rb.transform.rotation = Quaternion.Euler (0, 180, 0);
					LPanel.GetComponent<Image> ().enabled = false;
				}
			player.GetComponent <Animator> ().Play ("New Animation");
			move = true;
			if (player.GetComponent<Player> ().away == true)
				useSwap = true;
			if (player.GetComponent<Player> ().away == false)
				player.GetComponent <Animator> ().Play ("Jump");
		}
	}

	public void OnPointerUp (PointerEventData eventData){
		move = false;
		player.GetComponent <Animator> ().Play ("stay");
		RPanel.GetComponent<Image> ().enabled = true;
		LPanel.GetComponent<Image> ().enabled = true;
	}


	//////////////////////////////////////////////////////////////////////Others
	IEnumerator trsy(){
		if (useSwap) {
			yield return new WaitForSeconds (0.13f);
			s ();
			coroutine = null;
			useSwap = false;
		} else
			s ();
	}


	void s() {
		if (move) 
			rb.transform.position = Vector3.MoveTowards (rb.transform.position,rb.transform.position + 
				new Vector3(count,0,0),Player.speed*Time.deltaTime);
	}
		
}