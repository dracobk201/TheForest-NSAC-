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

	void OnTriggerEnter(Collider other) {
		if (Input.GetKey (KeyCode.E) && (other.tag == "Player")) {			
				if (GameMaster.instance.varEspaciosDisponibles != 0) {
					GameMaster.instance.varEspaciosDisponibles--;
					/*while (i < GameMaster.instance.casillas.Length){
						if (GameMaster.instance.casillas[i] == false )
						{
							//Image tmp = GameMaster.instance.goObjecto1.GetComponent<Image>();
							//tmp = GameMaster.instance.mango;
							GameMaster.instance.goObjecto1.SetActive(true);
							////////GameMaster.instance.goObjecto1.transform.position = casilla1;
							other.gameObject.SetActive(false);
							GameMaster.instance.casillas[i] = true;
							break;

						}
						i++;
					}*/
				} else {
					GameMaster.instance.goTextoDescrip.GetComponent<Text>().text = "No tienes espacios disponibles";
				}
	}
}
}