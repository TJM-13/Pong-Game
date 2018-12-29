using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BallController : MonoBehaviour {

	public float speed;
	public Text scoreText;
	public Text winText;
	public GameObject p1;
	public GameObject p2;
	public AudioSource hitSound;
	public AudioSource goalSound;
	public AudioSource winSound;

	private int player1Score = 0;
	private int player2Score = 0;

	private Rigidbody2D rb2d;
	private TrailRenderer trail;


	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = Vector2.right * speed;
		scoreText.text = player1Score + " : " + player2Score;
		winText.text = "";
		trail = gameObject.GetComponentInChildren<TrailRenderer> ();
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
	{
		return (ballPos.y - racketPos.y) / racketHeight;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.name == "Player Left") {
			float y = hitFactor (transform.position,
				          col.transform.position,
				          col.collider.bounds.size.y);
			Vector2 dir = new Vector2 (1, y).normalized;
			speed++;
			rb2d.velocity = dir * speed;
		} else if (col.gameObject.name == "Player Right" || col.gameObject.name == "AI") {
			float y = hitFactor (transform.position,
				          col.transform.position,
				          col.collider.bounds.size.y);
			Vector2 dir = new Vector2 (-1, y).normalized;
			speed++;
			rb2d.velocity = dir * speed;
		}
		trail.startColor = Random.ColorHSV (0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
		hitSound.Play ();
	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Left Wall"))
		{
			player2Score++;
			trail.Clear ();
			gameObject.transform.position = new Vector3 (0,0,0);
			rb2d.velocity = new Vector2(0,0);
			p1.transform.position = new Vector3 (-20, 0, 0);
			p2.transform.position = new Vector3 (20, 0, 0);
			Invoke ("ResetBall", 2);
			goalSound.Play ();
		}
		if (other.gameObject.CompareTag ("Right Wall"))
		{
			player1Score++;
			trail.Clear ();
			gameObject.transform.position = new Vector3 (0,0,0);
			rb2d.velocity = new Vector2 (0, 0);
			p1.transform.position = new Vector3 (-20, 0, 0);
			p2.transform.position = new Vector3 (20, 0, 0);
			Invoke ("ResetBall", 2);
			goalSound.Play ();
		}
		scoreText.text = player1Score + " : " + player2Score;

	}

	void ResetBall()
	{
		speed = 30;
		rb2d.velocity = new Vector2 (1, 0) * speed;
	}

	void Update ()
	{
		if (player1Score == 3)
		{
			winText.text = " PLAYER 1 WINS";
			winSound.Play();
			//.SetActive (false);
			Invoke("ReturnMenu", 5);
		}
		if (player2Score == 3)
		{
			winText.text = "PLAYER 2 WINS";
			winSound.Play();
			//gameObject.SetActive (false);
			Invoke("ReturnMenu", 5);
		}

	}
	
	void ReturnMenu()
	{
		SceneManager.LoadSceneAsync ("Menu", LoadSceneMode.Single);
	}
}
