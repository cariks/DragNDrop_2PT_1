using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDropScript : MonoBehaviour, IBeginDragHandler, 
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
		objektuSkripts.pedejaisVilktais = null;
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		velkObjRectTransf.anchoredPosition +=
		eventData.delta/objektuSkripts.kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
		kanvasGrupa.alpha = 1f;

		if (objektuSkripts.vaiIstajaVieta == false) {
			kanvasGrupa.blocksRaycasts = true;
		} else {
			objektuSkripts.pedejaisVilktais = null;
		}
		objektuSkripts.vaiIstajaVieta = false;
		
	}
}