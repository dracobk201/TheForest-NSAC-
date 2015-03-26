using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scrPasodeVida : MonoBehaviour {

	string Muerto = "Ha sido derrotado";
	float FinDelJuego = 50f;
    float restaDeVida = 0;
    float floDisminuir = 0.005f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        restaDeVida = GameMaster.instance.varEnergiaMaxima - GameMaster.instance.varEnvenamiento - floDisminuir;
		if (GameMaster.instance.varEnergiaMaxima >= 0f) {
            GameMaster.instance.varEnergiaMaxima = restaDeVida;// *Time.deltaTime;
			GameMaster.instance.goTextoDescrip.GetComponent<Text> ().text = "Energia= " + Mathf.RoundToInt(GameMaster.instance.varEnergiaMaxima);
            GameMaster.instance.imgBarraVida.GetComponent<Image>().type = Image.Type.Filled;
            GameMaster.instance.imgBarraVida.GetComponent<Image>().fillMethod = Image.FillMethod.Vertical;
            Debug.Log(restaDeVida / 100f);
            GameMaster.instance.imgBarraVida.GetComponent<Image>().fillAmount = (restaDeVida / 100f);// * Time.deltaTime;
		}else{
			GameMaster.instance.varEnergiaMaxima = 0f; 
			//GameMaster.instance.goTextoDescrip.GetComponent<Text> ().text = Muerto;
			FinDelJuego--;
		}
		if (FinDelJuego <= 0f)
			Application.LoadLevel ("GameOver");
	}
}
