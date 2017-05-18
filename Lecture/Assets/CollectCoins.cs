using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour {
	public int points;
	void OnTriggerEnter2D( Collider2D other) {
		Debug.Log ("Treasure: " + points);
	}
}
