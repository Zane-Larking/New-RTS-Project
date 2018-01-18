using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;

	public Vector3 offset;
	public float zoomSpeed = 4f;
	public float minZoom = 5f;
	public float maxZoom = 15f;
	public float minYaw = -45f;
	public float maxYaw = 45f;


	public float pitch = 2f;

	public float yawSpeed = 100f;

	public float currentZoom = 10f;
	public float currentYaw= 0f;

	// Update is called once after per frame
	void Update () {
		currentZoom -= Input.GetAxis ("Mouse ScrollWheel") * zoomSpeed;
		currentZoom = Mathf.Clamp (currentZoom, minZoom, maxZoom);

		currentYaw += Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
		currentYaw = Mathf.Clamp (currentYaw, minYaw, maxYaw);
	}
	
	// LateUpdate is called once after each frame
	void LateUpdate () {
		transform.position = target.position - offset* currentZoom;
		transform.LookAt (target.position + Vector3.up * pitch);

		transform.RotateAround (target.position, Vector3.up, currentYaw);
	}
}
