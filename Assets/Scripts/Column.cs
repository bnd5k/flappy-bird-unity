using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {


	private void OnTriggerEngter2d(Collider2D other)
	{
		if (other.GetComponent<Bird>() != null)
			{
				GameControl.instance.BirdScored();
			}
	}
}
