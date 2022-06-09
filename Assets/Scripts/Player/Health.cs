using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Sprite fullheart;
    public Sprite emptyheart;
    public GameObject[] Hearts;

    void Update()
    {
        for (int i = 0; i < Hearts.Length; i++)
        {
            if (i < health)
            {
                Hearts[i].GetComponent<SpriteRenderer>().sprite = fullheart;
            }else
            {
                Hearts[i].GetComponent<SpriteRenderer>().sprite = emptyheart;
            }
            if (i < numOfHearts)
            {
                Hearts[i].GetComponent<SpriteRenderer>().enabled = true;
            }else
            {
                Hearts[i].GetComponent<SpriteRenderer>().enabled = false;
            }
        }
        if (health <= 0)
        {
           SceneManager.LoadScene("GameOver"); 
        }
    }
    private void OnCollisionEnter(Collision other) {
        
        if (other.collider.tag == "Enemy")
        {
            Destroy(other.gameObject);
            health--;
            Debug.Log("Colidiu");
            Handheld.Vibrate();
        }
    }
}
