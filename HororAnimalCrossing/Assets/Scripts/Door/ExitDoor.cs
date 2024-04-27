using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] GameObject player;

    public Vector3 teleportPosition;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(player.transform.position.x + teleportPosition.x, player.transform.position.y + teleportPosition.y, player.transform.position.z + teleportPosition.z);
    }
}
