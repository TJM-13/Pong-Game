using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControllerHard : MonoBehaviour {

	public float speed;
	public GameObject ball;

	private Rigidbody2D rb2d;
	private Vector3 ballPos;
	private float lerpSpeed = 1f;
	private int difficulty = -20;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.freezeRotation = true;
	}


	void FixedUpdate ()
	{
		ballPos = ball.transform.position;
		if (ballPos.x >= difficulty && ballPos.y != 0) {
			if (ballPos.y > gameObject.transform.position.y) {
				if (rb2d.velocity.y < 0) {
					rb2d.velocity = Vector2.zero;
				}
				rb2d.velocity = Vector2.Lerp (rb2d.velocity, Vector2.up * speed, lerpSpeed * Time.deltaTime);
			} else if (ballPos.y < gameObject.transform.position.y) {
				if (rb2d.velocity.y > 0) {
					rb2d.velocity = Vector2.zero;
				}
				rb2d.velocity = Vector2.Lerp (rb2d.velocity, Vector2.down * speed, lerpSpeed * Time.deltaTime);
			} else {
				rb2d.velocity = Vector2.Lerp (rb2d.velocity, Vector2.zero * speed, lerpSpeed * Time.deltaTime);
			}
		}
	}
}