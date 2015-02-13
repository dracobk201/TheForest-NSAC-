using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	private static GameMaster _instance;

	#region variables
		//public int varEnergiaMaxima = 6;
		public int varEnergiaDisponible = 6;
		public int varEspaciosDisponibles = 1;
	#endregion

	#region variables booleanas
		public bool varObjecto1 = true;
		public bool varObjecto2 = true; 
		public bool varObjecto3 = true; 
		public bool varObjecto4 = true; 
		public bool varObjecto5 = true; 
	#endregion

	#region GameObject
		public GameObject goTextoEnergia;
		public GameObject goTextoObjetos;
		public GameObject goTextoDescrip;
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
}
