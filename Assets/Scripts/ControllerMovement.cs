using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour {
	public float MovementSpeed;
	public float SprintMultiplier;
	bool sprint = false;

	private float x = 0;
	private float z = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void LateUpdate () {
		if (Input.GetButtonDown("Sprint")) {
			sprint = !sprint;
		}

		if (sprint) {
			x = Input.GetAxis("Horizontal") * Time.deltaTime * MovementSpeed * SprintMultiplier;
		  z = Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed * SprintMultiplier;
		} else {
			x = Input.GetAxis("Horizontal") * Time.deltaTime * MovementSpeed;
		  z = Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed;
		}

    transform.Translate(x, 0, 0);
    transform.Translate(0, 0, z);
	}
}
