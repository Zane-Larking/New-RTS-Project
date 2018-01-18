using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

	public LayerMask movementMask;

	Camera cam;
	PlayerMotor motor;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
		motor = GetComponent<PlayerMotor> ();
	}
	
	// Update is called once per frame
	void Update () {
		//right click to move/direct attack
		//A + left click to Attack move
		if (Input.GetMouseButtonDown (1)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, movementMask)) {
				Debug.Log("We hit " + hit.collider.name + ", at " + hit.point);
				//do something with information about what was hit
					//if target is enemy, attack enemy

					//if target is an item, collect the item

					//if target is location, move to location
				motor.MoveToPoint(hit.point);
					
					//if Attack moved, clear target
			}
		}
	
	}
}
