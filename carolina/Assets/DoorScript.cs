using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	private Animator _animator;

	void Start() {
		_animator = GetComponent<Animator> ();
		_animator.SetBool ("open", false);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log(_animator.GetBool("open"));	
		Debug.Log ("collided");
		_animator.SetBool ("open", true);
		Debug.Log(_animator.GetBool("open"));
	}
}
