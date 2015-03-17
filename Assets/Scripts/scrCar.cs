using UnityEngine;
using System.Collections;

public class scrCar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter (Collider other){
		if (other.tag == "Player")
		GameMaster.instance.varInCar = true;
	}

	void onTriggerExit (Collider other){
		if (other.tag == "Player")
		GameMaster.instance.varInCar = false;
	}
}
