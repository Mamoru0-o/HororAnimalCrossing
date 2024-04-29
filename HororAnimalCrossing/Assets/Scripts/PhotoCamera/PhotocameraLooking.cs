using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PhotocameraLooking : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;
    private float _rotationY = 0;
    public float minimumHor = -40.0f;
    public float maximumHor = 80.0f;
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            //transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
            _rotationX += Input.GetAxis("Mouse X") * sensitivityHor;
            _rotationX = Mathf.Clamp(_rotationX, minimumHor, maximumHor);
            float rotationY = transform.localEulerAngles.x;
            transform.localEulerAngles = new Vector3(rotationY, _rotationX, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            _rotationY += Input.GetAxis("Mouse X") * sensitivityHor;
            _rotationY = Mathf.Clamp(_rotationY, minimumHor, maximumHor);
            float rotationX = transform.localEulerAngles.x;

            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
            
        }
    }
}
