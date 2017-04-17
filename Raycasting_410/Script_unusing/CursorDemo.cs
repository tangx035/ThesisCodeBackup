using UnityEngine;
using System.Collections;

public class CursorDemo : MonoBehaviour {

	public Transform mySphere; // assign reference in the Inspectior; call "transform" in Inspector

	float timeLookAt = 0f;
	// Update is called once per frame
	void Update () {
		//1.defien "Ray"
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		//2. save some memory for "RaycastHit"
		RaycastHit myRayHit = new RaycastHit();
		//2.5 visualize the ray
		Debug.DrawRay(myRay.origin, myRay.direction*10f, Color.red);
		//3. shoot the raycast now
		if (Physics.Raycast (myRay, out myRayHit, 100f)) {
			timeLookAt += Time.deltaTime;
			Debug.Log ("hitting something");
			Debug.Log ("hit"+ gameObject.name+"for"+timeLookAt);
		//	mySphere.transform.position = myRayHit.point; //"POINT" 
	    //	 if (Input.GetMouseButton (0)) {
	   //		Instantiate (mySphere, myRayHit.point, Quaternion.Euler (0f, 0f, 0f));
    	//	}
		} else {
			Debug.Log ("hitting nothing");
		}
	}
}

