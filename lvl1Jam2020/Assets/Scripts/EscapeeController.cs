using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EscapeeController : MonoBehaviour
{
    public GameObject navMeshAgentChild;
    public GameObject escapeeSprite;
    NavMeshAgent navMeshAgent;
    private void Start()
    {
        navMeshAgent = navMeshAgentChild.GetComponent<NavMeshAgent>();

        navMeshAgent.SetDestination(new Vector3(5.0F, 8.0F));
    }

    private void Update()
    {
        escapeeSprite.transform.position = navMeshAgentChild.transform.position;
    }

}
