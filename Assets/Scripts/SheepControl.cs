using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepControl : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name == "Grass")
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
