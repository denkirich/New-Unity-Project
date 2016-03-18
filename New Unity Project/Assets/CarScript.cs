using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 last = gameObject.transform.position;
            gameObject.transform.position = new Vector3(last.x, last.y + 0.1f);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 last = gameObject.transform.position;
            gameObject.transform.position = new Vector3(last.x, last.y - 0.1f);
        }
	}
}
