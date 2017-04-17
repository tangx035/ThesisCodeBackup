using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

		
	// Update is called once per frame
	void Update () {
		float mouseHorizontal = Input.GetAxis ("Mouse X");
		float mouseVertical = Input.GetAxis ("Mouse Y");


		//rotate the camera based on mouse speed
		transform.Rotate (-mouseVertical, mouseHorizontal, 0f);

	  // un-roll the camera by making sure Z is always zero, while preserving X and Y
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0f);

	}
}
