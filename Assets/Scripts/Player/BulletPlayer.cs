using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject spanw;
       void Start()
    {
       spanw = GameObject.FindGameObjectWithTag("SpawnPlayer");
       transform.eulerAngles = spanw.transform.eulerAngles;
       Destroy(gameObject,6.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward* speed * Time.deltaTime);
    }
}