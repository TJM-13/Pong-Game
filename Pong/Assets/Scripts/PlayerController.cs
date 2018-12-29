using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public string axis = "Vertical";

	private Rigidbody2D rb2d;


	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.freezeRotation = true;
	}
	

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis (axis);
		Vector2 movement = new Vector2 (0, moveVertical);
		rb2d.velocity = movement * speed;
	}
}
