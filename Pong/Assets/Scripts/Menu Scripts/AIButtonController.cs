using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AIButtonController : MonoBehaviour, IPointerEnterHandler {

	public GameObject easy;
	public GameObject normal;
	public GameObject hard;

	public void OnPointerEnter(PointerEventData eventData)
	{
		easy.SetActive (true);
		normal.SetActive (true);
		hard.SetActive (true);


	}
		
}
