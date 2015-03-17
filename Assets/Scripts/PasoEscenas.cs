using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PasoEscenas : MonoBehaviour {

	float PasoDeImagenes = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "PantallaTitulo") {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();
			}
			if (Input.GetKey (KeyCode.Space)) {
				Application.LoadLevel ("PantallaLoading");
			}
		} else if (Application.loadedLevelName == "PantallaLoading") {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();
			}
			if (PasoDeImagenes <= 500f)
			{
				//PasoDeImagenes = PasoDeImagenes + 0.8f;
				PasoDeImagenes++;
			}
			
			if (PasoDeImagenes == 100f){
				GameObject.FindGameObjectWithTag ("Texto").GetComponent<Text>().text = "Revisa cada rincon del mapa";
				//GameObject.FindGameObjectWithTag ("Imagen").GetComponent<Image>().sprite = (Sprite) Resources.Load("img1");
			}
			if (PasoDeImagenes == 200f){
				GameObject.FindGameObjectWithTag ("Texto").GetComponent<Text>().text = "Vigila tu indicador de energia";
				//GameObject.FindGameObjectWithTag ("Imagen").GetComponent<Image>().sprite = (Sprite) Resources.Load("variaciones 1");
			}
			if (PasoDeImagenes == 300f){
				GameObject.FindGameObjectWithTag ("Texto").GetComponent<Text>().text = "¿Pacman estara detras de esto?";
				//GameObject.FindGameObjectWithTag ("Imagen").GetComponent<Image>().sprite = (Sprite) Resources.Load("variaciones 1.2_2");
			}
			if (PasoDeImagenes == 400f){
				GameObject.FindGameObjectWithTag ("Texto").GetComponent<Text>().text = "Como sabras este texto no sera el definitivo";
				//GameObject.FindGameObjectWithTag ("Imagen").GetComponent<Image>().sprite = (Sprite) Resources.Load("variaciones 2.2_2");
			}
			if (PasoDeImagenes >= 500f){
				GameObject.FindGameObjectWithTag ("Texto").GetComponent<Text>().text = "Listo. Presiona Espacio";
				//GameObject.FindGameObjectWithTag ("Imagen").GetComponent<Image>().sprite = (Sprite) Resources.Load("variaciones 2.3_2");
				if (Input.GetKey(KeyCode.Space)){
					Application.LoadLevel("Prototipov1");
				}
			}
		} else if (Application.loadedLevelName == "GameOver") {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();
			}
			if (Input.GetKey (KeyCode.Space)) {
				Application.LoadLevel ("PantallaTitulo");
			}
		} else if (Application.loadedLevelName == "Prototipov1") {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();
			}
		}
	}
}