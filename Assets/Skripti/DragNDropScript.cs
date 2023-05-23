using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDropScript : MonoBehaviour, 
	IPointerDownHandler, IBeginDragHandler, 
	IDragHandler, IEndDragHandler{
	//Uzglaba noradi uz Objekti skriptu
	public Objekti objektuSkripts;
	//Velkam objektam piestiprinata CanvasGroup komponnte
	private CanvasGroup kanvasGrupa;
	//Objekta atrasanas vieta, kurs tiek parvietots
	private RectTransform velkObjRectTransf;


	void Start()
	{
		//Pieklust objektam piestiprinatajai CanvasGroup
		//komponentei
		kanvasGrupa = GetComponent<CanvasGroup> ();
		//Pieklust objekta RectTransform komponentei
		velkObjRectTransf = GetComponent<RectTransform> ();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log ("Uzklikskinats uz velkama objekta!");
	}

	public void OnDrag(PointerEventData eventData)
	{

	}

	public void OnEndDrag(PointerEventData eventData)
	{

	}
		
}