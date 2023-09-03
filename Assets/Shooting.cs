using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public float range = 100f;
    public Camera camera;
    public AudioSource fireSound;
    public int numDead = 0;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            fireSound.Play();
            Shoot();
        }
        
    }

    void Shoot() {
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range)) {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null) {
                target.Die();
                if(target.hasCard) {
                    numDead--;
                } else {
                    numDead++;
                }
                
            }
        }
    }
}
