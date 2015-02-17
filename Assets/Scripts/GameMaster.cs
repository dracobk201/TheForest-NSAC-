using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	private static GameMaster _instance;

	#region variables
		//public int varEnergiaMaxima = 6;
		public int varEnergiaDisponible = 6;
		public int varEspaciosDisponibles = 6;
		//public bool[] casillas = new bool[6] {false, false, false, false, false, false};
	public bool[] casillas;
	#endregion

	#region GameObject
		public GameObject goTextoEnergia;
		public GameObject goTextoObjetos;
		public GameObject goTextoDescrip;
		public GameObject goObjecto1;
		public GameObject goObjecto2; 
		public GameObject goObjecto3; 
		public GameObject goObjecto4; 
		public GameObject goObjecto5; 
		public GameObject goObjecto6; 

		public Texture2D mango;
	#endregion

	/*#region Ubicaciones
		public Vector3 casilla1 = new Vector3(208,-76,0);
		public Vector3 casilla2 = new Vector3(298,-76,0);
		public Vector3 casilla3 = new Vector3(208,-117,0);
		public Vector3 casilla4 = new Vector3(298,-117,0);
		public Vector3 casilla5 = new Vector3(208,-156,0);
		public Vector3 casilla6 = new Vector3(298,-156,0);
	#endregion*/

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

	void Start () {
		casillas = new bool[6] {false, false, false, false, false, false};
	}
}
