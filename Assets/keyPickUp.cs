using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPickUp : MonoBehaviour
{
    public GameObject exit;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().useGravity = false;
    }


    public void HeldUp() {
        exit.GetComponent<BoxCollider>().enabled = true;
    }

    public void Detach()
    {
        exit.GetComponent<BoxCollider>().enabled = false;
    }

}
