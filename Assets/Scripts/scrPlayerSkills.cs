using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scrPlayerSkills : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.V)) {
			if (GameMaster.instance.varEspaciosDisponibles == 0) {
				GameMaster.instance.varEnergiaDisponible++;

				//Debug.Log("Procedo a consumir el objeto");
				GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Procedo a consumir el objeto";
				if (GameMaster.instance.varEnergiaDisponible > 6) {
					GameMaster.instance.varEnergiaDisponible = 6;
				}
				GameMaster.instance.varEspaciosDisponibles++;
				GameMaster.instance.goTextoEnergia.GetComponent<Text>().text = "Energia = " + GameMaster.instance.varEnergiaDisponible;
				GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
			} else {
				//Debug.Log("No tienes un objeto a la mano");
				GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "No tienes un objeto a la mano";
			}
		}
	}
}
