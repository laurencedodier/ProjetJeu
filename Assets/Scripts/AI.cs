﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour {
    public GameObject cible;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<NavMeshAgent>().SetDestination(cible.transform.position);
        if (GetComponent<NavMeshAgent>().velocity.magnitude >= 0.1f)
        {
            GetComponent<Animator>().SetFloat("vitesse",1);
        }
    }
}
