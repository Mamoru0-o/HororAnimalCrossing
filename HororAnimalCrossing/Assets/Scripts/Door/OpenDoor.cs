using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject pressKey;
    [SerializeField] GameObject player;

    public Vector3 teleportPosition;

    private bool isTrigger = false;

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
            player.transform.position = new Vector3(player.transform.position.x + teleportPosition.x, player.transform.position.y + teleportPosition.y, player.transform.position.z + teleportPosition.z);
        }
    }
}
