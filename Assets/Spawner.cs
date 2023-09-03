using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject student;
    public int maxStudent;
    
    int currentStudentCount;
    System.Random random;
    void Start()
    {
        StartCoroutine(SpawnerFunc(maxStudent));
    }

    IEnumerator SpawnerFunc(int maxStudent) {
        while(currentStudentCount < maxStudent) {

            Instantiate(student, transform.position, Quaternion.identity);
            
            yield return new WaitForSeconds(0.2f);
            currentStudentCount++;
        }

    }

    
}
