using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    [SerializeField] GameObject pressKey;
    [SerializeField] GameObject Item;
    [SerializeField] GameObject player;
    public GameObject theDest;
    public bool pickup;
    private float speed = 3.0f;

    private bool isTrigger = false;
    private bool isTriggerGo = false;


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
            isTriggerGo = true;
            Destroy(pressKey);
        }
        if (isTriggerGo)
        {

            if ((theDest.transform.position - transform.position).sqrMagnitude < 0.01f) Destroy(gameObject);
            Item.GetComponent<Rigidbody>().useGravity = false;
            Item.GetComponent<CapsuleCollider>().isTrigger = true;
            Item.transform.position += (theDest.transform.position - transform.position).normalized * speed * Time.deltaTime;
            
        }
        
    }
}

