using UnityEngine;
using System.Collections;

public class Flutuar : MonoBehaviour {

	public float bounce = 1f;

	public bool onlyAffectInteractableItems = false;

	void Start () {
		if (GetComponent<Collider> ()) {
			GetComponent<Collider>().isTrigger = true;
		}
	}
	
	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Rigidbody> ()) {
			if (onlyAffectInteractableItems) {
				if (other.GetComponent<InteractableItem> ()) {
					other.GetComponent<Rigidbody> ().AddForce (bounce * Vector3.up, ForceMode.Impulse);
				}
			} else {
				other.GetComponent<Rigidbody> ().AddForce (bounce * Vector3.up, ForceMode.Impulse);
			}
		}
	}

	void OnTriggerStay(Collider other){
		if (other.GetComponent<Rigidbody> ()) {
			if (onlyAffectInteractableItems) {
				if (other.GetComponent<InteractableItem> ()) {
						other.GetComponent<Rigidbody> ().AddForce (bounce * Vector3.up, ForceMode.Impulse);
				}
			} else {
				other.GetComponent<Rigidbody> ().AddForce (bounce * Vector3.up, ForceMode.Impulse);
			}
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.blue;
		if (GetComponent<BoxCollider> ()) {
			BoxCollider c = GetComponent<BoxCollider> ();
			Gizmos.DrawWireCube (transform.position, c.bounds.size);
		}
	}
}
