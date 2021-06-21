﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenExitDoor : MonoBehaviour
{
    public GameObject Entrance1;
    public GameObject Entrance2;
    public GameObject Key;

    private void Start()
    {
        this.GetComponent<BoxCollider>().enabled = false;
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider key)
    {
        Debug.Log("tag is key");
        
        Entrance1.GetComponent<Animator>().enabled = true;
        Entrance2.GetComponent<Animator>().enabled = true;
        StartCoroutine("Wait3Sec");
        this.GetComponent<AudioSource>().enabled = true;
        Destroy(Key);
     
    }

    IEnumerator Wait3Sec()
    {
        yield return new WaitForSeconds(3);
        Destroy(Entrance1);
        Destroy(Entrance2);
    }
}
