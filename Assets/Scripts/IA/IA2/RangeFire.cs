using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeFire : MonoBehaviour
{
    public Transform RangerFire;
    public float speed;
    void Start()
    {
        
    }
    void Update()
    {
        Attack();
    }
     void Attack()
    {
        transform.LookAt(RangerFire,Vector3.up);
        transform.position = Vector3.MoveTowards(transform.position, RangerFire.position, speed* Time.deltaTime);
    }
}
