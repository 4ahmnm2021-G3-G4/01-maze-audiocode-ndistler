using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    GameObject[] treesGO = new GameObject[7];
    public GameObject pickUpManager;
         
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject tree in treesGO) { 
            tree.SetActive(false);
        }
        treesGO[0].SetActive(true);

        pickUpManager.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (counter == 5)
        {
            this.GetComponent<BoxCollider>().enabled = false;

            pickUpManager.SetActive(true);

            StartCoroutine("Wait3Sec");

            Debug.Log("counter 5");
        }

        if(counter == 6)
        {
            
        }



        if (other.CompareTag("Player"))
        {
            counter++;
            treesGO[counter - 1].SetActive(false);
            treesGO[counter].SetActive(true);
            this.GetComponent<BoxCollider>().center = new Vector3(treesGO[counter].transform.position.x, treesGO[counter].transform.position.y, treesGO[counter].transform.position.z);
          }

        


    }

    IEnumerator Wait3Sec()
    {
        yield return new WaitForSeconds(3);

        treesGO[6].GetComponent<AudioSource>().enabled = false;

    }

}
