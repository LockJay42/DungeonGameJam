﻿using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start()
    {	}
	
	// Update is called once per frame
	void Update()
    {
        
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("End"))
            LevelManager.LoadPlayableLevelRandomly();  
    }
}
