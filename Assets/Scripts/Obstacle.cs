﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boder")
        {
            Destroy(gameObject);
        }
        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
