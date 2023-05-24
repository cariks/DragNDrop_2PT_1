using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour {
	public Objekti objektuSkripts;

	void Updater()
	{
		if (objektuSkripts.pedejaisVilktais != null) 
		{
			if(Input.GetKeyUp(KeyCode.Z))
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform> ().Rotate (0, 0, Time.deltaTime * 9f);

			}

			if(Input.GetKeyUp(KeyCode.X))
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform> ().Rotate (0, 0, -Time.deltaTime * 9f);

			}
		}
	}
}