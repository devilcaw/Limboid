using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeOnTrig : MonoBehaviour {
	public Sprite AfterSprite;
	public Rigidbody2D body;


	void OnCollisionEnter2D (Collision2D col) {
		if (col.transform.tag == "Player") {
			GetComponent<SpriteRenderer> ().sprite = AfterSprite;
			body.bodyType = RigidbodyType2D.Dynamic;

			Destroy (this);
		}			
	}
}
