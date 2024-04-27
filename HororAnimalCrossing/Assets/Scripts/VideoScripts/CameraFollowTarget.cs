using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class CameraFollowTarget : MonoBehaviour
{
    [SerializeField] GameObject BoxLook;
    float speedlook = 2.0f;

    public Transform target;
    Vector3 targetPos;
    public Vector3 offsetPos;
    public float moveSpeed = 5;
    public float smooth = 0.2f;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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

    public void EventLook()
    {
        transform.position += (BoxLook.transform.position - transform.position).normalized * speedlook * Time.deltaTime;
        
    }

    public void EventLookDown()
    {
        transform.position -= (BoxLook.transform.position - transform.position).normalized * speedlook * Time.deltaTime;
        if ((BoxLook.transform.position - transform.position).sqrMagnitude < 0.01f)
        {
            transform.position = Vector3.zero;
        };
    }

}
