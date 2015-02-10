using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scrObjetoBloque : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider collider) {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (GameMaster.instance.varEspaciosDisponibles != 0) {
				Debug.Log("Acabas de agarrar un objeto");
				GameMaster.instance.varEspaciosDisponibles--;
				GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
				GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Acabas de agarrar un objeto";
			} else {
				Debug.Log("Ya tienes un objeto en la mano");
				GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Ya tienes un objeto en la mano";
			}
		}
	}
}
