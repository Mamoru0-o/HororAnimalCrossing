using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject pressKey;
    [SerializeField] GameObject player;

    public Vector3 teleportPosition;

    private void OnTriggerEnter(Collider other)
    {
        pressKey.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
     
        if (Input.GetKeyUp(KeyCode.E))
        {
            player.transform.position = new Vector3(player.transform.position.x + teleportPosition.x, player.transform.position.y + teleportPosition.y, player.transform.position.z + teleportPosition.z);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pressKey.SetActive(false);
    }

}
