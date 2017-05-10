using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platMove : MonoBehaviour {

	public GameObject[] plats;
	private Vector3[] platPos;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < plats.Length; i++) {
			
			platPos[i] = plats [i].transform.position;
		}
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A))
			plats [3].transform.position = new Vector3 (plats [3].transform.position.x, 0.17f, plats [3].transform.position.z);
	}
}
