using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scrControlPersonaje : MonoBehaviour {
	
	public float speed = 10f;
	Inventory inventory;

	void Start () {
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory> ();
	}
	// Update is called once per frame
	void Update () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;
		
		if (Input.GetKeyDown (KeyCode.V)) {
			Vector3 positionCubo = GameMaster.instance.cnvMenu.GetComponent<RectTransform>().transform.position ;
			if (GameMaster.instance.varCnvMenuActivo == false){
				GameMaster.instance.cnvMenu.GetComponent<RectTransform>().transform.position = new Vector3 (positionCubo.x-300,positionCubo.y, positionCubo.z);
				GameMaster.instance.varCnvMenuActivo = true;
			}
			else {
				GameMaster.instance.cnvMenu.GetComponent<RectTransform>().transform.position = new Vector3 (positionCubo.x+300,positionCubo.y, positionCubo.z);
				GameMaster.instance.varCnvMenuActivo = false;
			}
		}
	}
	
	void OnTriggerStay(Collider other) {
		//Aún no se que poner aqui, quizas interaccion con entorno
//		if (Input.GetMouseButtonDown(1)) {
        if (Input.GetKeyDown (KeyCode.E))
        {
			if (other.gameObject.tag == "Recolectable") {
				int valor = int.Parse(other.gameObject.name);
				inventory.addItem (valor);
				other.gameObject.SetActive (false);
			}
		}
	}
    void onTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Finish")
        {
            GameMaster.instance.varInCar = true;
        }

    }

    void onTriggerExit(Collider other)
    {
        if (other.tag == "Finish")
        {
            GameMaster.instance.varInCar = false;
        }

    }
}