using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class student_movement : MonoBehaviour
{
    public int SPEED = 5;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3 (0, 0, SPEED);
    }
}
