using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float damping = 1;
    public float lookAhead = 3;
    public float lookAheadReturnSpeed = 0.5f;
    public float lookAheadMoveThreshold = 0.1f;
    public float yPosBounds = -1;

    float offset;
    Vector3 lastTargetPosition;
    Vector3 currentVelocity;
    Vector3 lookAheadPos;

    // Start is called before the first frame update
    void Start()
    {
        lastTargetPosition = target.position;
        offset = (transform.position - target.position).z;
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            return;
        }

        float xMoveDelta = (target.position - lastTargetPosition).x;
        bool updateLookAhead = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;

        if (updateLookAhead)
        {
            lookAheadPos = lookAhead * Vector3.right * Mathf.Sign(xMoveDelta);
        }
        else
        {
            lookAheadPos = Vector3.MoveTowards(lookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);
        }

        Vector3 aheadTargetPos = target.position + lookAheadPos + Vector3.forward * offset;
        Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref currentVelocity, damping);

        newPos = new Vector3(newPos.x, Mathf.Clamp(newPos.y, yPosBounds, Mathf.Infinity), newPos.z);

        transform.position = newPos;
        lastTargetPosition = target.position;
    }
}
