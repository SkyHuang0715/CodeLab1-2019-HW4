﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        Debug.Log("Clicked on the black cube!");
        GameManager.instance.Score -= 10;

        Destroy(gameObject);

    } 
}
