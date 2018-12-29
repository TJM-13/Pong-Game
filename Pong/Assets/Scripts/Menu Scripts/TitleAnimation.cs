using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleAnimation : MonoBehaviour {

	public Text title;
	private float timeToGo;

	void start()
	{
		title = this.GetComponent<Text> ();
		timeToGo = Time.fixedTime + 0.02f;
	}

	void Update ()
	{
		title.rectTransform.Rotate (new Vector3(0f, 2f, 0f));
		if (Time.fixedTime >= timeToGo) {
			title.color = Random.ColorHSV (0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
			timeToGo = Time.fixedTime + 0.02f;
		}
	}
}
