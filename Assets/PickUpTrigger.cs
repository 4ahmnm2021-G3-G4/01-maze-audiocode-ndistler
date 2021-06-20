using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTrigger : MonoBehaviour
{
    [SerializeField]
    PickUpManager pickUpManagerO;



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
        Debug.Log("PickedUp");
        pickUpManagerO.counter++;
        Destroy(this.gameObject);
        
     
    }

    
}
