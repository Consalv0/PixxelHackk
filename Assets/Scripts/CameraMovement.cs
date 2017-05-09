using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public GameObject focusOn;
    public float distance = 10;

    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    private Quaternion rotationVector;
    private Vector3 distVector;

  void Start () {
    rotationVector = Quaternion.Euler(45, 0, 0);
	}

	void LateUpdate () {
    distVector = new Vector3(0, 0, distance);
    var ObjectPosition = focusOn.transform.position;
    distVector = Quaternion.AngleAxis(45, Vector3.right) * distVector;
    ObjectPosition = ObjectPosition - distVector;
    transform.position = Vector3.SmoothDamp(transform.position, ObjectPosition, ref velocity, 0.2f);
    transform.rotation = Quaternion.Slerp(transform.rotation, rotationVector, 0.2f);
	}
}
