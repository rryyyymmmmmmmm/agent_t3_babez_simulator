using System.Collections;
using System.Collections.Generic;

using UnityEngine;
    using UnityEngine.AI;

public class mouse : MonoBehaviour
{
    public float turnx;
    public float turny;
    public float sens;
    public Transform goo;
    public Transform orient;
    public Vector3 def;
    public Transform gun;
    public Vector3 gun_offset;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {

        transform.position = goo.position + def;
        gun.transform.position += gun_offset;

        float x = Input.GetAxis("Mouse X")*Time.deltaTime * sens;
        float y = Input.GetAxis("Mouse Y")*Time.deltaTime * sens;
        

        turnx +=x;
        turny += y;

        turny = Mathf.Clamp(turny, -90f, 90f);

        transform.localRotation = Quaternion.Euler(-turny, turnx, 0);
        
        orient.localRotation = Quaternion.Euler(0, turnx, 0);
 
    }


}
