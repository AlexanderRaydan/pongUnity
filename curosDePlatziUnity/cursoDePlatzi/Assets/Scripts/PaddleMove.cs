using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(Input.mousePosition);

		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

		transform.position = new Vector3 ( transform.position.x , Mathf.Clamp(mousePos.y , -3.8f , 3.8f ) , 0 );

		// mover el objeto con la posicion del mouse , el math.clamp es para que el objeto o pase la pantalla 
		
	}
}
