﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag != "EntryRoom" && other.gameObject.tag !="Player")
        Destroy(other.gameObject);
    }
}
