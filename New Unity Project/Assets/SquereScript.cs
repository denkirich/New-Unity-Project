using UnityEngine;
using System.Collections;

public class SquereScript : MonoBehaviour { 
    public Sprite X;
    public Sprite O;

    public bool IsSet = false;
    // Use this for initialization
    void Start () {
        ConnectionScript.IsXExpected = true;
    }

    // Update is called once per frame
    void Update () {

	}

    void OnMouseDown()
    {
        if (!IsSet)
        {
            if (ConnectionScript.IsXExpected)
            {
                GetComponent<SpriteRenderer>().sprite = X;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = O;
            }

            IsSet = true;
            ConnectionScript.IsXExpected = !ConnectionScript.IsXExpected;
        }
    }
}
