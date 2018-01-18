using UnityEngine;
using System.Collections;

public class UnitCreator : MonoBehaviour {

	public GameObject Soldier;
	public Camera cam;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = cam.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;

		if (Physics.Raycast (ray, out hitInfo)) {
			Soldier.transform.position = hitInfo.point;
		}
		if (Input.GetButton("Jump") && Input.GetMouseButtonDown (0)) {
			Instantiate (Soldier, Soldier.transform.position, Quaternion.Euler (Vector3.up));
		}
	}
}