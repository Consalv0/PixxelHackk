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
    float posZ = distance*0.5f;
    transform.position = Vector3.SmoothDamp(transform.position, focusOn.transform.position, ref velocity, 0.2f);
    var cameraPosition = transform.position;
    transform.position = new Vector3(cameraPosition.x, cameraPosition.y, -posZ);
	}
}
