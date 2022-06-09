using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackIA1 : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public ParticleSystem effect;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        Attack();
    }
     void Attack()
    {
        transform.LookAt(Player.transform.position,Vector3.up);
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed* Time.deltaTime);
    }
     void OnCollisionEnter(Collision other) 
    {
        if (other.collider.tag == "Shield")
        {
            effect.Play();
            FindObjectOfType<AudioManager>().Play("Explosion");
            Destroy(gameObject,0.1f);
        }
        if (other.collider.tag == "FirePlayer")
        {
            effect.Play();
            FindObjectOfType<AudioManager>().Play("Explosion");
            Destroy(other.gameObject);
            Destroy(gameObject,0.1f);
        }
    }
    
}
