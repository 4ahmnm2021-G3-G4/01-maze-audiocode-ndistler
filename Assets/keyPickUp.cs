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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        

    }

    public void LetLose() {
        this.GetComponent<Rigidbody>().useGravity = true;
        exit.GetComponent<BoxCollider>().enabled = true;
        Destroy(this.gameObject);
    }

}
