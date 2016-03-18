using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {
    public float X;

    public float Y;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(X, Y);
	}
}
