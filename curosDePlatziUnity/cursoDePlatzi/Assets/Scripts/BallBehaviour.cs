using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	public Transform paddle ;

	bool gameStart = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(!gameStart){

		float posDiferen = paddle.position.x - transform.position.x; // la diferencia entre las posiciones de el paddle y la polota , para que la pelota aparezca justo adelante

		transform.position = new Vector3( paddle.position.x - posDiferen , paddle.position.y , 0 );
		}

		if(Input.GetMouseButtonDown(0)) // el cero es el click izquierdo (el primer comando de la funcion) cuando le den click el juego comienza y la pelota deja de segir a el paddle
			gameStart = true;
	}
}
