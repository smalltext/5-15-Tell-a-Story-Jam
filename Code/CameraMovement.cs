using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	void Start () {
		
	}

    public void UpdatePosition()
    {
        //Manual update loop called by Player, which can be stopped
    }

    public void MoveTo(Vector2 place)
    {
        //Pans camera to desired position
    }

    public void MoveBack()
    {
        //Pans camera back to original position
    }
}
