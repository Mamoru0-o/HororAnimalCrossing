using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    [SerializeField] GameObject pressKey;
    [SerializeField] GameObject player;

    private bool isTrigger = false;

    private void Start()
    {
        pressKey.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        pressKey.SetActive(true);
        isTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        pressKey.SetActive(false);
        isTrigger = false;
    }
    private void Update()
    {
        if (isTrigger && Input.GetKeyUp(KeyCode.E))
        {
            
        }
    }
}

