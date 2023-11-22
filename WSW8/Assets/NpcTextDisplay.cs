using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTextDisplay : MonoBehaviour
{
    public GameObject UiElement;
    // Start is called before the first frame update
    void Start()
    {
        UiElement.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UiElement.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        UiElement.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
