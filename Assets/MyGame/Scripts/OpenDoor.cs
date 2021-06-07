using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject DoorPt1;
    public GameObject DoorPt2;
    public GameObject Trigger;

    Animator dooranim1;
    Animator dooranim2;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //DoorPt1.transform.position = new Vector3(DoorPt1.transform.position.x - 5, DoorPt1.transform.position.y, DoorPt1.transform.position.z);
        //DoorPt2.transform.position = new Vector3(DoorPt2.transform.position.x + 5, DoorPt2.transform.position.y, DoorPt2.transform.position.z);
        Animator dooranim1 = DoorPt1.GetComponent<Animator>();
        Animator dooranim2 = DoorPt2.GetComponent<Animator>();

        dooranim1.enabled = true;
        dooranim2.enabled = true;
    }
}
