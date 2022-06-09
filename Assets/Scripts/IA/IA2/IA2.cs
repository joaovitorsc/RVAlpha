using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA2 : MonoBehaviour
{
    public GameObject [] waypoints;
    public ParticleSystem effect;
    public GameObject Bullet;
    public GameObject SpawnBullet, player;
    public bool rangeFire;
    public float nextfire, firerate;
    int current = 0;
    float rotspeed;
    public float speed;
    float WPradius = 0.5f;
    void Start() 
    {
     rangeFire = false;
     player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
       Movement();
       Attack();
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
        SpawnBullet.transform.LookAt(player.transform,Vector3.up);
    }
    void Attack()
    {
        if(nextfire <= 0 && rangeFire == true  )
        {
            FindObjectOfType<AudioManager>().Play("FireEnemy");
            Instantiate(Bullet,SpawnBullet.transform.position,SpawnBullet.transform.rotation);
            nextfire = firerate;
        }
        nextfire --;
    }
   void OnCollisionEnter(Collision other) 
   {
        if (other.collider.tag == "Fire")
        {
            rangeFire = true;
            Debug.Log("Atira");
        }

        if (other.collider.tag == "FirePlayer")
        {
           effect.Play();
           FindObjectOfType<AudioManager>().Play("Explosion");
           Destroy(other.gameObject);
           Destroy(gameObject,0.2f);
        }      
   }
}
