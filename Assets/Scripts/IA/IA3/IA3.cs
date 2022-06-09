using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IA3 : MonoBehaviour
{
    // Start is called before the first frame update
   public int health;
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Boss");
         FindObjectOfType<AudioManager>().Stop("bg");
    }
    // Update is called once per frame
    void Update()
    {
        Dead();
    }
    private void OnCollisionEnter(Collision other) 
    {
        if (other.collider.tag == "FirePlayer")
        {
            FindObjectOfType<AudioManager>().Play("Explosion");
            health --;
        }
    }
   public  void Dead()
    {
        if (health <=0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
