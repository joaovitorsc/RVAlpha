using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    
    public void MainGame(string NameScene)
    {   
       StartCoroutine(LoadGame(NameScene)); 
    }
    IEnumerator LoadGame(string name) 
    {  
        yield return new WaitForSeconds(.30f); 
        SceneManager.LoadScene(name);

    }
}
