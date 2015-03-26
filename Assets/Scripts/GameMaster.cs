using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMaster : MonoBehaviour {

	private static GameMaster _instance;

	#region variables
	public float varEnergiaMaxima = 100;
	public float varEnvenamiento = 0f;
	public int varEspaciosDisponibles;
	public int varEspaciosMaximos;
	public bool varCnvMenuActivo = false;
	public bool varInCar = false;
	#endregion

	#region GameObject
		public GameObject goTextoDescrip;
		public GameObject cnvMenu;
        public Image imgBarraVida;
	#endregion

	public static GameMaster instance
	{
		get
		{
			//If _instance hasn't been set yet, we grab it from the scene!
			//This will only happen the first time this reference is used.
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<GameMaster>();
			return _instance;
		}
	}

	void Start (){
		//varEspaciosMaximos = 1;
		//varEspaciosDisponibles = varEspaciosMaximos;
	}
}