using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav_mesh_student : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform win_yro7;
    // Start is called before the first frame update
    
    void Start() {
        win_yro7 = GameObject.Find("winYro7").transform;
    }
    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(win_yro7.position);
    }
}
