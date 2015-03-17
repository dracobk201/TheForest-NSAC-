using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scrPasodeVida : MonoBehaviour {

	string Muerto = "Ha sido derrotado";
	float FinDelJuego = 50f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameMaster.instance.varEnergiaMaxima >= 0f) {
			GameMaster.instance.varEnergiaMaxima = GameMaster.instance.varEnergiaMaxima - GameMaster.instance.varEnvenamiento - 0.05f;
			GameMaster.instance.goTextoDescrip.GetComponent<Text> ().text = "Energia= " + GameMaster.instance.varEnergiaMaxima;
		}else{
			GameMaster.instance.varEnergiaMaxima = 0f;
			GameMaster.instance.goTextoDescrip.GetComponent<Text> ().text = Muerto;
			FinDelJuego--;
		}
		if (FinDelJuego <= 0f)
			Application.LoadLevel ("GameOver");
	}
}
