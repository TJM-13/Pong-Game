using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayController : MonoBehaviour, IPointerEnterHandler {

	public GameObject easy;
	public GameObject normal;
	public GameObject hard;


	public void OnPointerEnter(PointerEventData eventData)
	{
		easy.SetActive (false);
		normal.SetActive (false);
		hard.SetActive (false);
	}
}
