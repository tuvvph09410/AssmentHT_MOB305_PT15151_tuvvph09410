﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemaster : MonoBehaviour
{
public int points = 0;
 
    public Text pointtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     pointtext.text = ("Points: " + points);  
    }
}
