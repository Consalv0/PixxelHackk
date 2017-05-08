using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public GameObject focusOn;
    public float distance;
    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;

  void Start () {
	}

	void LateUpdate () {
    var ObjectPosition = focusOn.transform.position;
    var rotationVector = Quaternion.Euler(45, 0, 0);
    var distVector = new Vector3(0, 0, distance);
    distVector = Quaternion.AngleAxis(45, Vector3.right) * distVector;
    ObjectPosition = ObjectPosition - distVector;
    transform.position = Vector3.SmoothDamp(transform.position, ObjectPosition, ref velocity, 0.2f);
    transform.rotation = Quaternion.Slerp(transform.rotation, rotationVector, 0.2f);
	}
}
