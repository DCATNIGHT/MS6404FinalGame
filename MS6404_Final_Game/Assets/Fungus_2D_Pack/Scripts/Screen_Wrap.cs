using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Wrap : MonoBehaviour {



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var cam = Camera.main;

        var viewportPosition = cam.WorldToViewportPoint(transform.position);

        var newPosition = transform.position;

        if (viewportPosition.x > 1 || viewportPosition.x < 0)
        {
            newPosition.y = -newPosition.y;
        }

        if (viewportPosition.y > 1 || viewportPosition.y < 0)
        {
            newPosition.y = -newPosition.y;
        }

        transform.position = newPosition;
    }
}
