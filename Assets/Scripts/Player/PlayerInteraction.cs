using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject SpawnBullet;
    public float nextfire, firerate;
    private ManoGestureContinuous grab;
    private ManoGestureContinuous open;
    private GameObject playerUI;
    public GameObject aim,shield;
    private string handTag = "SpawnPlayer";
    private Renderer cubeRenderer;

    void Start()
    {
        SpawnBullet = GameObject.FindGameObjectWithTag("SpawnPlayer");
        Initialize();       
    }

    private void Initialize()
    {

        grab = ManoGestureContinuous.CLOSED_HAND_GESTURE;
        open = ManoGestureContinuous.OPEN_HAND_GESTURE;

    }
    private void Update() 
    {
        AttackandDefense();
        nextfire --;
        
    }
    /// <summary>
    /// If grab is performed while hand collider is in the cube.
    /// The cube will follow the hand.
    /// </summary>
    private void AttackandDefense()
    {
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == grab)
        {
            shield.SetActive(true);
            aim.SetActive(false);
        }
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_continuous == open)
        { 
            shield.SetActive(false);
            aim.SetActive(true);
            
            if (nextfire <= 0)
            {
                FindObjectOfType<AudioManager>().Play("FirePlayer");
                Instantiate(Bullet,SpawnBullet.transform.position,SpawnBullet.transform.rotation);
                 nextfire = firerate;
            }
                
          
        }
    }
}