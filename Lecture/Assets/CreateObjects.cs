using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour {
	public GameObject objectToCreate;
	public float startXMin, startXMax;
	public float startYMin, startYMax;
	public int numberOfObjects;
	// Use this for initialization
	void Start () {
		CreateRandomObject ();
	}

	void CreateRandomObject(){
		for (int i = 0; i < numberOfObjects; i++) {
			float x = Random.Range (startXMin, startXMax);
			float y = Random.Range (startYMin, startYMax);
			Instantiate (objectToCreate, new Vector3 (x, y, 0), Quaternion.identity);
		}
	}
}
