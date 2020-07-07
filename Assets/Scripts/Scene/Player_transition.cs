﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_transition : MonoBehaviour
{
 
 public GameObject target;
    
    void Awake() {
        GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.transform.position = target.transform.GetChild(0).transform.position;
        }
    }

}
