using UnityEngine;
using System.Collections;

public class EarthRotate : MonoBehaviour {
	public float EarthSpeed = -5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
    // Slowly rotate the object around its X axis at 1 degree/second.
    transform.Rotate(Vector3.down * EarthSpeed * Time.deltaTime / Time.timeScale);
    //GameObject.Find("Earth").transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 0), 5f * Time.deltaTime);

    }
}
