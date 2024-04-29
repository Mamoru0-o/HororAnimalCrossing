using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeItem : CameraFollowTarget
{
    [SerializeField] new Camera camera;
    private bool Triggertake = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {

            /*for (int i = 100; i < 1; i--)
            {
                other.gameObject.transform.localScale.Set(other.gameObject.transform.localScale.x - (other.gameObject.transform.localScale.x * i/100 )
                    , other.gameObject.transform.localScale.y - (other.gameObject.transform.localScale.y * i / 100)
                    , other.gameObject.transform.localScale.z - (other.gameObject.transform.localScale.z * i / 100));
            }*/
            Triggertake = true;
            Destroy(other.gameObject);
        }
    }


}
