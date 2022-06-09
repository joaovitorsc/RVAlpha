﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollider : MonoBehaviour
{
    #region Singleton
    private static HandCollider _instance;
    public GameObject SpawnBullet, Bullet;
    public float sensibilidade;
    public static HandCollider Instance
    {
        get
        {
            return _instance;
        }

        set
        {
            _instance = value;
        }
    }
    #endregion

    private TrackingInfo tracking;
    public Vector3 currentPosition;

    /// <summary>
    /// Set the hand collider tag.
    /// </summary>
    private void Start()
    {
        gameObject.tag = "SpawnPlayer";
    }

    /// <summary>
    /// Get the tracking information from the ManoMotionManager and set the position of the hand Collider according to that.
    /// </summary>
    void Update()
    {
        tracking = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;
        currentPosition = Camera.main.ViewportToWorldPoint(new Vector3(tracking.palm_center.x + sensibilidade , tracking.palm_center.y + sensibilidade, tracking.depth_estimation));
        transform.position = currentPosition;
        if (Input.GetKey(KeyCode.Space))
        {
             Instantiate(Bullet,SpawnBullet.transform.position,SpawnBullet.transform.rotation);
        }
    }
}