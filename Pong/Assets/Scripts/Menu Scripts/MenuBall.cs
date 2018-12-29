using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBall : MonoBehaviour {

	public int speed;
	private Rigidbody2D rb2d;
	private TrailRenderer trail;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (Random.Range (0f, 1f), Random.Range (0f, 1f)) * speed;
		trail = gameObject.GetComponentInChildren<TrailRenderer> ();
		trail.startColor = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name == "Main Camera")
		{
			trail.startColor = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
		}
	}

}
