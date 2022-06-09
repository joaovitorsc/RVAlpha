using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA3Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Boss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other) 
   {
        if (other.collider.tag == "FirePlayer")
        {
           FindObjectOfType<AudioManager>().Stop("bg");
           Boss.SetActive(true);
           Destroy(other.gameObject);
           Destroy(gameObject,0.2f);
        }      
   }
}
