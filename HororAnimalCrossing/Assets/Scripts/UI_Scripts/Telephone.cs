using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class Telephone : MonoBehaviour
{
    [SerializeField] GameObject telephone;
    private bool activeTelephone = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && activeTelephone == false)
        {
            telephone.SetActive(true);
            activeTelephone = true;
        }
        else if (Input.GetKeyDown(KeyCode.I) && activeTelephone)
        {
            telephone.SetActive(false);
            activeTelephone = false;
        }
    }
}
