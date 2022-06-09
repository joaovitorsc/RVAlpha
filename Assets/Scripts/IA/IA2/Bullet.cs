using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    
    public GameObject Player;
    void Start()
    {
       Player = GameObject.FindGameObjectWithTag("Player");
       Destroy(gameObject,7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed* Time.deltaTime);
    }
    private void OnCollisionEnter(Collision other) 
    {
        if (other.collider.tag == "Shield")
        {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("Impact");
        }
    }
}
