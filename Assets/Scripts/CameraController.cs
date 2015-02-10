using UnityEngine;
using System.Collections;

// Camera Controller
// Revision 2
// Allows the camera to move left, right, up and down along a fixed axis.
// Attach to a camera GameObject (e.g MainCamera) for functionality.

public class CameraController : MonoBehaviour {
	
	//float Xmax, Ymax;
	int UP = 1;
	int DOWN = 2;
	int LEFT = 3;
	int RIGHT = 4;
	int dir = 0;
	int rot = 0;
	int RLEFT = 1;
	int RRIGHT = 2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W)) {
			dir = UP;
			
		} else if (Input.GetKeyDown(KeyCode.S)) {
			dir = DOWN;
		} else if (Input.GetKeyDown(KeyCode.A)) {
			dir = LEFT;
			
		} else if (Input.GetKeyDown(KeyCode.D)) {
			dir = RIGHT;
		} else if (Input.GetKeyUp(KeyCode.W) | Input.GetKeyUp(KeyCode.S) | Input.GetKeyUp(KeyCode.A) | Input.GetKeyUp(KeyCode.D)) {
			dir = 0;
		} 
		
		if (Input.GetKeyDown(KeyCode.Q)) {
			rot = RLEFT;
		} else if (Input.GetKeyDown(KeyCode.E)) {
			rot = RRIGHT;
		} else if (Input.GetKeyUp(KeyCode.Q) | Input.GetKeyUp(KeyCode.E)) {
			rot    = 0;
		}        
		
		//camera scroll
		if (dir==UP) {
			transform.Translate(0,0,5*Time.deltaTime);
		} else if (dir==DOWN) {
			transform.Translate(0,0,-5*Time.deltaTime);
		} else if (dir==LEFT) {
			transform.Translate(-5*Time.deltaTime,0,0);                
		} else if (dir==RIGHT) {        
			transform.Translate(5*Time.deltaTime,0,0);        
		}
		//camera rotation
		if (rot == RLEFT ) {
			transform.Rotate(0,25*Time.deltaTime,0);
			transform.LookAt(transform.position);
		} else if (rot == RRIGHT ) {
			transform.Rotate(0,-25*Time.deltaTime,0);
			transform.LookAt(transform.position);
		}             
		
		
	}
}