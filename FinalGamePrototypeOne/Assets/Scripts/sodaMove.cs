using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sodaMove : MonoBehaviour {
	
	public GameObject bru;
	private Vector3 bruPos;
	// Use this for initialization
	void Start () {
		bruPos = bru.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		bru.transform.position = new Vector3 ( Mathf.Sin (Time.time *5) * -1.2f + .4f, bru.transform.position.y, bru.transform.position.z -0.05f);


		if (bru.transform.position.z < -4.7)
			bru.transform.position = bruPos;
	}
}
