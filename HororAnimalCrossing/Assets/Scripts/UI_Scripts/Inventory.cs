using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject inventory;
    [SerializeField] GameObject telephone;
    [SerializeField] GameObject iventCamera;
    [SerializeField] GameObject photoCamera;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !telephone.activeSelf && !inventory.activeSelf && !photoCamera.activeSelf)
        {
            inventory.SetActive(true);
            iventCamera.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I) && !telephone.activeSelf && inventory.activeSelf && !photoCamera.activeSelf)
        {
            inventory.SetActive(false);

            iventCamera.SetActive(false);
        }
    }
}
