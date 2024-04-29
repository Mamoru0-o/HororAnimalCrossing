using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class CameraFollowTarget : MonoBehaviour
{

    public Transform target;
    Vector3 targetPos;
    public Vector3 offsetPos;
    public float moveSpeed = 5;
    public float smooth = 0.2f;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        MoveWithTarget();
    }
    void MoveWithTarget()
    {
        targetPos = target.transform.position + offsetPos;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smooth);
    }

    public void EventLook(Camera camera)
    {
        
    }

    public void EventLookDown(Camera camera)
    {
        
    }

}
