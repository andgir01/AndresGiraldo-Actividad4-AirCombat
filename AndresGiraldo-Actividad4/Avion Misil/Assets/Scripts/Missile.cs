using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//mover hacia adelante
		this.transform.Translate (0.0f, 0.0f, 8.0f);

	}

	void OnCollisionEnter(Collision collision) { 

		if (collision.collider.gameObject.tag == "Enemigo") {

			//carga el prefab de una explosion
			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Explosion") as GameObject);

			//Muevo la explosion
			explosion.transform.position = collision.collider.gameObject.transform.position;

			//Eliminamos el piso
			Destroy (collision.collider.gameObject);

			//Destruye el misil
			Destroy (this.gameObject);
		
		}
		//Cambiar color
		if (collision.collider.gameObject.tag == "Aliado") {
			
			collision.collider.gameObject.GetComponent<Light> ().color = new Color (0, 0, 1);

			//Destruir el misil
			Destroy (this.gameObject);
		}
	}	

}
