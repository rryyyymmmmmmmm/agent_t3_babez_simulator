using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;


public class playermove : MonoBehaviour
{
  
    public float speed;
    public Transform orien;
    float hor;
    float ver;

    bool grounded = false;
    
    
    Vector3 direction;
    public float jumpforce;

    Rigidbody rb;

     void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }
    private void MyInput()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");
    }

    private void PlayerMove()
    {

        direction = orien.forward * ver + orien.right * hor;


        rb.AddForce(direction.normalized * speed*100,ForceMode.Force);

    }


    void Update()
    {
        
        MyInput();

       
    }
    private void FixedUpdate()
    {

       

        if (grounded == true)
        {
          
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0, jumpforce * 1000, 0, ForceMode.Impulse);

                grounded = false;

            }
           

        }


        PlayerMove();
    }
}
