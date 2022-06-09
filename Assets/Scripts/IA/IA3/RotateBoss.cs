using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoss : MonoBehaviour
{
   // Start is called before the first frame update
    public Transform boss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(boss.transform.position,Vector3.back,0.5f);
    }
}

