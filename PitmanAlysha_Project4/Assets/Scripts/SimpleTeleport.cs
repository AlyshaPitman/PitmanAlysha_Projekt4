﻿using UnityEngine;
using System.Collections;


public class SimpleTeleport : MonoBehaviour {
	public GameObject destination;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		other.transform.position = destination.transform.position;
	}

}
