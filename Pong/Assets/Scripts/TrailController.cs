using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailController : MonoBehaviour {
	public TrailRenderer trail;

	void Start()
	{
		trail = GetComponent<TrailRenderer> ();
		trail.sortingLayerName = "Trail";
	}

}
