﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewRoomGenerate : MonoBehaviour
{
    public string sceneName;
    public int levelReq;
    public GameObject roomNew, roomOld;
    public float scalerX, scalerY;

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (GameManager.playerLevel == levelReq)
            {
                SceneManager.LoadScene(sceneName);
            }
            Instantiate(roomNew, new Vector3 (transform.position.x + scalerX, transform.position.y + scalerY, 0), transform.rotation);
            Destroy(roomOld);
        }
    }
}
