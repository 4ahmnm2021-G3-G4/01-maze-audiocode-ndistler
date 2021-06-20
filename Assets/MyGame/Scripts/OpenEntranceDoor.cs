using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEntranceDoor : MonoBehaviour
{
    public GameObject Entrance1;
    public GameObject Entrance2;
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
        Entrance1.GetComponent<Animator>().enabled = true;
        Entrance2.GetComponent<Animator>().enabled = true;
        StartCoroutine("Wait3Sec");

    }
    IEnumerator Wait3Sec()
    {
        yield return new WaitForSeconds(3);
        Destroy(Entrance1);
        Destroy(Entrance2);
    }
}
