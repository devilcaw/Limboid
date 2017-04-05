using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimberPlatform : MonoBehaviour {
	bool exit = true;
	Rigidbody2D body;

	void Start() {
		body = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.transform.tag == "Player")
			exit = false;
	}
	void OnCollisionExit2D(Collision2D col) {
		if (col.transform.tag == "Player")
			exit = true;
	}

	void Update() {
		if ((exit == true) & (transform.rotation != Quaternion.identity) & (body.bodyType != RigidbodyType2D.Static)) {
			if (transform.rotation.z < Quaternion.identity.z) {
				transform.Rotate (new Vector3 (0, 0, 25 * Time.deltaTime));
				if (transform.rotation.z > Quaternion.identity.z)
					transform.rotation = Quaternion.identity;
			} else {
				transform.Rotate (new Vector3 (0, 0, -25 * Time.deltaTime));
				if (transform.rotation.z < Quaternion.identity.z)
					transform.rotation = Quaternion.identity;
			}
		}
	}
}
