using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour {


	Renderer rend;
	Renderer rend1;
	Renderer rend2;
	public Material[] mats;

	public GameObject[] plats;
	// Use this for initialization
	void Start () {
		rend = plats[0].GetComponent<Renderer> ();
		rend1 = plats[1].GetComponent<Renderer> ();
		rend2 = plats[2].GetComponent<Renderer> () ;

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.A)) 
			rend.material.color = Color.white;
		
		if (Input.GetKeyUp(KeyCode.A))
				rend.material = mats [0];

		if (Input.GetKeyDown (KeyCode.W))
			rend1.material.color = Color.white;
		
		if (Input.GetKeyUp(KeyCode.W))
			rend1.material = mats[1];

		if (Input.GetKeyDown (KeyCode.D))
			rend2.material.color = Color.white;

		if (Input.GetKeyUp(KeyCode.D))
			rend2.material = mats[2];
		
	}
}
