using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject telephone;
    [SerializeField] GameObject telephoneCamera;
    [SerializeField] GameObject iventCamera;

    public void OnCameraOn()
    {
        telephone.SetActive(false);
        telephoneCamera.SetActive(true);
        iventCamera.SetActive(false);
    }
}
