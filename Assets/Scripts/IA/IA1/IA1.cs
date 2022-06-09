using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA1 : MonoBehaviour
{
    public GameObject [] waypoints;
    public ParticleSystem effect;
    int current = 0;
    float rotspeed;
    public float speed;
    float WPradius = 0.1f;
    void Update()
    {
       Movement();
    }
    void Movement()
    {
             if (Vector3.Distance(waypoints[current].transform.position, transform.position)< WPradius)
                {
                    current++;
                        if (current >= waypoints.Length)
                        {
                            current = 0;
                        }
                }   
        transform.position = Vector3.MoveTowards(transform.position,waypoints[current].transform.position, Time.deltaTime * speed);
    }
    void OnCollisionEnter(Collision other) 
    {
        if (other.collider.tag == "Shield")
        {
            effect.Play();
            FindObjectOfType<AudioManager>().Play("Impact");
            FindObjectOfType<AudioManager>().Play("Explosion");
            Destroy(gameObject);
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
