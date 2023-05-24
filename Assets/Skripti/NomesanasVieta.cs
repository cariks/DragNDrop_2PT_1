using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour,
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;

	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null) 
		{
			if (eventData.pointerDrag.tag.Equals (tag)) 
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform> ().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform> ().transform.eulerAngles.z;

				rotacijasStarpiba =
					Mathf.Abs (vietasZRot - velkObjZRot);

				vietasIzm =
					eventData.pointerDrag.
					GetComponent<RectTransform> ().localScale;

				velkObjIzm =
					GetComponent<RectTransform> ().localScale;

				xIzmStarpiba = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs (vietasIzm.y - velkObjIzm.y);
				
				Debug.Log ("Objektu rotacijas starpiba: " + rotacijasStarpiba + 
					"\nPlatuma starpiba: " + xIzmStarpiba +
					"\nAugstuma starpiba: " + yIzmStarpiba);

				if (rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1)) 
				{
					Debug.Log ("Nomests pareizaja vieta!");
				}

			}
		}
	}
		

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
