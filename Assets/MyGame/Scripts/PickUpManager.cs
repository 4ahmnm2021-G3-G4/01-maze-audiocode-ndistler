using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpManager : MonoBehaviour
{
    [SerializeField]
    public string counttext;
    public int counter;
    public Text countshow; 

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counttext = counter + "/3";
        countshow.text = counttext;
    }
}
