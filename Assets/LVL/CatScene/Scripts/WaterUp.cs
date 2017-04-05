using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterUp : MonoBehaviour {
	bool onTrig;
	public Transform upPoint;
	GameObject timber;

	void Start() {
		upPoint.position = new Vector3 (upPoint.position.x, upPoint.position.y, 0);
	}

	void Update () {
		if (onTrig)
		if (timber.transform.position != upPoint.position) {
			timber.transform.position = Vector2.MoveTowards (timber.transform.position, upPoint.position, 15 * Time.deltaTime);
		} else
			Destroy (this);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Timber") {
			onTrig = true;
			timber = col.gameObject;
			Rigidbody2D rigid = timber.GetComponent<Rigidbody2D> ();
			rigid.constraints = RigidbodyConstraints2D.FreezePosition;
			rigid.angularDrag = 250;
			rigid.drag = 50;
		}
	}
}
