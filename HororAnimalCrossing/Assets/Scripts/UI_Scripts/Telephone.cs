using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class Telephone : MonoBehaviour
{
    [SerializeField] GameObject telephone;
    [SerializeField] GameObject iventCamera;
    [SerializeField] GameObject photoCamera;
    [SerializeField] GameObject inventory;
    private bool activeTelephone = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && activeTelephone == false && !photoCamera.activeSelf && !inventory.activeSelf)
        {
            telephone.SetActive(true);
            activeTelephone = true;
            iventCamera.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.T) && photoCamera.activeSelf)
        {
            telephone.SetActive(true);
            activeTelephone = true;
            iventCamera.SetActive(true);
            photoCamera.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.T) && activeTelephone)
        {
            telephone.SetActive(false);
            activeTelephone = false;
            iventCamera.SetActive(false);
        }
    }
}
