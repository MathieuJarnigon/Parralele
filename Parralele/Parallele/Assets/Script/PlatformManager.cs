using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public Transform startPoint;
    public bool verticall;
    public bool horizontal;
    public Transform endPoint;
    public float speed;

    private bool isMovingToEnd = true;

    void FixedUpdate()
    {
        Vector3 direction = isMovingToEnd ? (endPoint.position - transform.position).normalized : (startPoint.position - transform.position).normalized;
        if (verticall == true)
            transform.position += new Vector3(0, direction.y * speed * Time.fixedDeltaTime, 0);
        else if (horizontal == true)
            transform.position += new Vector3(direction.x * speed * Time.fixedDeltaTime, 0, 0);

        if (Vector3.Distance(transform.position, isMovingToEnd ? endPoint.position : startPoint.position) < 1f)
        {
            isMovingToEnd = !isMovingToEnd;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(startPoint.position, 0.2f);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(endPoint.position, 0.2f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(startPoint.position, endPoint.position);
    }
}
