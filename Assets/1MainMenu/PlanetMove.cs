using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMove : MonoBehaviour
{

    // Use this for initialization  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {

        GameObject.Find("Sun").transform.Rotate(Vector3.up * Time.deltaTime * 0.5f);

        GameObject.Find("Mercury").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0.1f, 1, 0), 267.8f * Time.deltaTime);
        //设置公转的方向和速度  
        GameObject.Find("Mercury").transform.Rotate(Vector3.up * Time.deltaTime * 2);
        //设置自转  

        GameObject.Find("Venus").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, -0.1f), 196.5f * Time.deltaTime);
        GameObject.Find("Venus").transform.Rotate(Vector3.up * Time.deltaTime * 1);

        GameObject.Find("Earth").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 168f * Time.deltaTime);
        GameObject.Find("Earth").transform.Rotate(Vector3.up * Time.deltaTime * 4);

        GameObject.Find("Mars").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0.2f, 1, 0), 134.75f * Time.deltaTime);
        GameObject.Find("Mars").transform.Rotate(Vector3.up * Time.deltaTime * 3);

        GameObject.Find("Jupiter").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(-0.1f, 2, 0), 71.35f * Time.deltaTime);
        GameObject.Find("Jupiter").transform.Rotate(Vector3.up * Time.deltaTime * 8);

        GameObject.Find("Saturn").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0.2f), 54f * Time.deltaTime);
        GameObject.Find("Saturn").transform.Rotate(Vector3.up * Time.deltaTime * 7);

        GameObject.Find("Uranus").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 2, 0.1f), 38.12f * Time.deltaTime);
        GameObject.Find("Uranus").transform.Rotate(Vector3.up * Time.deltaTime * 6);

        GameObject.Find("Neptune").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(-0.1f, 1, -0.1f), 30.4f * Time.deltaTime);
        GameObject.Find("Neptune").transform.Rotate(Vector3.up * Time.deltaTime * 5);

    }
}
