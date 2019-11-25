﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpColor : MonoBehaviour {

    private Material mat;
	// Use this for initialization
	void Start () {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        mat.SetFloat("_WorldY", transform.position.y);
        mat.SetFloat("_ScaleY", transform.localScale.y);
	}
}
