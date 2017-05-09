using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : MonoBehaviour {
	public float rotationSpeed = 30;

	private float x = 0;
	private float y = 0;
	private float newAngle;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.rotation = Quaternion.Euler(transform.rotation.x + 45, transform.rotation.y, transform.rotation.z);

		if (Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical")) > 0) {
			x = Input.GetAxis("Horizontal") * Time.deltaTime;
			y = Input.GetAxis("Vertical") * Time.deltaTime;
		}

		newAngle = Mathf.Atan2(-x, y) * Mathf.Rad2Deg;

		Quaternion newRotation = Quaternion.AngleAxis(newAngle, Vector3.back);
		transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * 0.01f);
	}
}
