using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		//Movemos hacia arribba
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 2.0f, 0.0f);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -2.0f, 0.0f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (0.0f, 0.0f, -2.0f);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (0.0f, 0.0f, 2.0f);
		}


		//Tecla espacio presionada
		if (Input.GetKeyDown (KeyCode.Space)) {

			//Reconstruyo un gameObject a partir
			//de la informacion guardada en un prefab 

			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);

			missile.transform.SetParent (this.gameObject.transform);
			missile.transform.localPosition = new Vector3 (0.03f, 1.59f, 2.47f);
			missile.transform.SetParent (null);
			 
		}
	}
}
