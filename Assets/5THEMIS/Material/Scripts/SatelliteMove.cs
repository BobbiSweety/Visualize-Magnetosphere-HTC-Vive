﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteMove : MonoBehaviour
{

    // Use this for initialization  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
       

        GameObject.Find("Satellite").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0.1f, 1, 0), -30f * Time.deltaTime);
        //设置公转的方向和速度  
     


    }
}
