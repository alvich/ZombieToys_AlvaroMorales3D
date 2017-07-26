using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;  

public class enemigocosa1 : MonoBehaviour {
    public NavMeshAgent agente;
    public Transform destino;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        agente.SetDestination(destino.position);

		//YAY divertido
	}
}
