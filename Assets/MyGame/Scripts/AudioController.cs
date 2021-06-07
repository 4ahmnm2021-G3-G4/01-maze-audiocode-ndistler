using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    GameObject[] treesGO = new GameObject[6];

    int counter;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject tree in treesGO) { 
            tree.SetActive(false);
        }
        treesGO[0].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            counter++;
            treesGO[counter - 1].SetActive(false);
            treesGO[counter].SetActive(true);
            this.GetComponent<BoxCollider>().center = new Vector3(treesGO[counter].transform.position.x, treesGO[counter].transform.position.y, treesGO[counter].transform.position.z);

            /*if (Tree1.active)
            {
                Tree1.SetActive(false);
                Tree2.SetActive(true);
            }*/
        }


    }


}
