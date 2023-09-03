using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    nav_mesh_student nav_Mesh_Student;
    public bool hasCard;
    //Animator animator;
    public System.Random random = new System.Random();
    public Transform card;
    public Transform winyro7;
    public TextMeshProUGUI text;
    
    void Start() {
        //animator = GetComponent<Animator>();
        winyro7 = GameObject.Find("winYro7").transform;
        nav_Mesh_Student = GetComponent<nav_mesh_student>();
        randomizeCard();

        
    }
    void OnTriggerEnter(Collider trigger) {
        if(trigger.CompareTag("Trigger")) {
            showCard();
        }
        if(trigger.CompareTag("Destroyer")) {
            Destroy(gameObject);
        }
    }
    
    public void Die() {
        //animator.SetBool("dead", true);
        nav_Mesh_Student.enabled = false;
        if(hasCard) {
            Debug.Log("he was innocent!!");
        }
        Destroy(gameObject);
    }
    bool RandomBool() {
        return random.Next() > random.Next();
    }
    public void randomizeCard() {
        hasCard = RandomBool();
        card.GetComponent<MeshRenderer>().enabled = false;
        
    }
    void showCard() {
        if(hasCard) {
            card.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
