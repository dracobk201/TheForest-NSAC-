using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {
	
	public float speed = 5f;
	public Vector3 casilla1 = new Vector3(208,-76,0);
	public Vector3 casilla2 = new Vector3(298,-76,0);
	public Vector3 casilla3 = new Vector3(208,-117,0);
	public Vector3 casilla4 = new Vector3(298,-117,0);
	public Vector3 casilla5 = new Vector3(208,-156,0);
	public Vector3 casilla6 = new Vector3(298,-156,0);
	
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
		if (Input.GetKey (KeyCode.Space)) {
			switch (other.name) {
			case "Objeto1":
				Debug.Log ("Mango");
				if (GameMaster.instance.varEspaciosDisponibles != 0) {
					//Debug.Log("Acabas de agarrar un objeto");
					GameMaster.instance.varEspaciosDisponibles--;
					GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Acabas de agarrar un objeto";
					int i = 0;
					Debug.Log (GameMaster.instance.casillas.Length);
					while (i < GameMaster.instance.casillas.Length){
						Debug.Log("Paso");
						if (GameMaster.instance.casillas[i] == false )
						{

							//Image tmp = GameMaster.instance.goObjecto1.GetComponent<Image>();
							//tmp = GameMaster.instance.mango;
							GameMaster.instance.goObjecto1.SetActive(true);
							////////GameMaster.instance.goObjecto1.transform.position = casilla1;
							other.gameObject.SetActive(false);
							GameMaster.instance.casillas[i] = true;
							Debug.Log(i);
							break;

						}
						i++;
					}
				} else {
					Debug.Log("Ya tienes un objeto en la mano");
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Ya tienes un objeto en la mano";
				}
				break;
			case "Objeto2":
				Debug.Log ("Manzana");
				if (GameMaster.instance.varEspaciosDisponibles != 0) {
					//Debug.Log("Acabas de agarrar un objeto");
					GameMaster.instance.varEspaciosDisponibles--;
					GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Acabas de agarrar un objeto";
					int i = 0;
					Debug.Log (GameMaster.instance.casillas.Length);
					while (i < GameMaster.instance.casillas.Length){
						Debug.Log("Paso");
						int j = 0;
						if (GameMaster.instance.casillas[i] == false )
						{
							
							//Image tmp = GameMaster.instance.goObjecto1.GetComponent<Image>();
							//tmp = GameMaster.instance.mango;
							GameMaster.instance.goObjecto2.SetActive(true);
							////////GameMaster.instance.goObjecto1.transform.position = casilla1;
							other.gameObject.SetActive(false);
							GameMaster.instance.casillas[i] = true;
							Debug.Log(i);
							break;
							
						}
						i++;
					}
				} else {
					Debug.Log("Ya tienes un objeto en la mano");
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Ya tienes un objeto en la mano";
				}
				break;
			case "Objeto3":
				Debug.Log ("Cambur");
				if (GameMaster.instance.varEspaciosDisponibles != 0) {
					//Debug.Log("Acabas de agarrar un objeto");
					GameMaster.instance.varEspaciosDisponibles--;
					GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Acabas de agarrar un objeto";
					int i = 0;
					Debug.Log (GameMaster.instance.casillas.Length);
					while (i < GameMaster.instance.casillas.Length){
						Debug.Log("Paso");
						int j = 0;
						if (GameMaster.instance.casillas[i] == false )
						{
							
							//Image tmp = GameMaster.instance.goObjecto1.GetComponent<Image>();
							//tmp = GameMaster.instance.mango;
							GameMaster.instance.goObjecto3.SetActive(true);
							////////GameMaster.instance.goObjecto1.transform.position = casilla1;
							other.gameObject.SetActive(false);
							GameMaster.instance.casillas[i] = true;
							Debug.Log(i);
							break;
							
						}
						i++;
					}
				} else {
					Debug.Log("Ya tienes un objeto en la mano");
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Ya tienes un objeto en la mano";
				}
				break;
			case "Objeto4":
				Debug.Log ("Mango");
				if (GameMaster.instance.varEspaciosDisponibles != 0) {
					//Debug.Log("Acabas de agarrar un objeto");
					GameMaster.instance.varEspaciosDisponibles--;
					GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Acabas de agarrar un objeto";
					int i = 0;
					Debug.Log (GameMaster.instance.casillas.Length);
					while (i < GameMaster.instance.casillas.Length){
						Debug.Log("Paso");
						int j = 0;
						if (GameMaster.instance.casillas[i] == false )
						{
							
							//Image tmp = GameMaster.instance.goObjecto1.GetComponent<Image>();
							//tmp = GameMaster.instance.mango;
							GameMaster.instance.goObjecto4.SetActive(true);
							////////GameMaster.instance.goObjecto1.transform.position = casilla1;
							other.gameObject.SetActive(false);
							GameMaster.instance.casillas[i] = true;
							Debug.Log(i);
							break;
							
						}
						i++;
					}
				} else {
					Debug.Log("Ya tienes un objeto en la mano");
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Ya tienes un objeto en la mano";
				}
				break;
			case "Objeto5":
				Debug.Log ("Mango");
				if (GameMaster.instance.varEspaciosDisponibles != 0) {
					//Debug.Log("Acabas de agarrar un objeto");
					GameMaster.instance.varEspaciosDisponibles--;
					GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Acabas de agarrar un objeto";
					int i = 0;
					Debug.Log (GameMaster.instance.casillas.Length);
					while (i < GameMaster.instance.casillas.Length){
						Debug.Log("Paso");
						int j = 0;
						if (GameMaster.instance.casillas[i] == false )
						{
							
							//Image tmp = GameMaster.instance.goObjecto1.GetComponent<Image>();
							//tmp = GameMaster.instance.mango;
							GameMaster.instance.goObjecto5.SetActive(true);
							////////GameMaster.instance.goObjecto1.transform.position = casilla1;
							other.gameObject.SetActive(false);
							GameMaster.instance.casillas[i] = true;
							Debug.Log(i);
							break;
							
						}
						i++;
					}
				} else {
					Debug.Log("Ya tienes un objeto en la mano");
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Ya tienes un objeto en la mano";
				}
				break;
			case "Objeto6":
				Debug.Log ("Mango");
				if (GameMaster.instance.varEspaciosDisponibles != 0) {
					//Debug.Log("Acabas de agarrar un objeto");
					GameMaster.instance.varEspaciosDisponibles--;
					GameMaster.instance.goTextoObjetos.GetComponent<Text>().text = "Disponible = " + GameMaster.instance.varEspaciosDisponibles;
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Acabas de agarrar un objeto";
					int i = 0;
					Debug.Log (GameMaster.instance.casillas.Length);
					while (i < GameMaster.instance.casillas.Length){
						Debug.Log("Paso");
						int j = 0;
						if (GameMaster.instance.casillas[i] == false )
						{
							
							//Image tmp = GameMaster.instance.goObjecto1.GetComponent<Image>();
							//tmp = GameMaster.instance.mango;
							GameMaster.instance.goObjecto6.SetActive(true);
							////////GameMaster.instance.goObjecto1.transform.position = casilla1;
							other.gameObject.SetActive(false);
							GameMaster.instance.casillas[i] = true;
							Debug.Log(i);
							break;
							
						}
						i++;
					}
				} else {
					Debug.Log("Ya tienes un objeto en la mano");
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "Ya tienes un objeto en la mano";
				}
				break;
			}
		}
	}
	//}
}