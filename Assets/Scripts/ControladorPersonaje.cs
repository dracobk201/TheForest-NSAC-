using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {
	
	public float speed = 5f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		
		if(Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		
		if(Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		
		if(Input.GetKey(KeyCode.S)) {
			transform.Translate(Vector3.back * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.V)) {
			//Debug.Log ("Aqui pasa algo");
			if (GameMaster.instance.varEspaciosDisponibles == 0) {
				GameMaster.instance.varEnergiaDisponible++;
				
				//Debug.Log("Procedo a consumir el objeto");
				GameMaster.instance.goTextoDescrip.GetComponent<Text> ().text = "Procedo a consumir el objeto";
				if (GameMaster.instance.varEnergiaDisponible > 6) {
					GameMaster.instance.varEnergiaDisponible = 6;
				}
				GameMaster.instance.varEspaciosDisponibles++;
				GameMaster.instance.goTextoEnergia.GetComponent<Text> ().text = "Energia = " + GameMaster.instance.varEnergiaDisponible;
				GameMaster.instance.goTextoObjetos.GetComponent<Text> ().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
			} else {
				//Debug.Log("No tienes un objeto a la mano");
				GameMaster.instance.goTextoDescrip.GetComponent<Text> ().text = "No tienes un objeto a la mano";
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		switch (other.name) {
		case "Objeto1":
			Debug.Log ("You are 1");
			break;
		case "Objeto2":
			Debug.Log ("You are 2");
			break;
		case "Objeto3":
			Debug.Log ("You are 3");
			break;
		case "Objeto4":
			Debug.Log ("You are 4");
			break;
		case "Objeto5":
			Debug.Log ("You are 5");
			break;
		case "Objeto6":
			Debug.Log ("You are 6");
			break;
		}
		}
	//}
}