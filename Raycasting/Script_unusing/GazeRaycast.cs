using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put this script on the thing to be looked at
// do not put on the player or camera!!
public class GazeRaycast : MonoBehaviour {

	float timeLookedAt = 0f; // number of seconds we looked at this thing
	string hitedObejctName;
	string lookingTime;
	void Update () {
		// 1. calculate the Raycast origin and direction
		Ray ray = new Ray( Camera.main.transform.position, Camera.main.transform.forward );

		// 2. setup our RaycastHit riable, reserve memory for it
		RaycastHit myRayHit = new RaycastHit();

		Debug.DrawRay( ray.origin, ray.direction * 50f, Color.yellow );

		// 3. test our Raycast
		if ( Physics.Raycast( ray, out myRayHit, 50f ) ) {
				hitedObejctName = myRayHit.collider.gameObject.name;
			//if (myRayHit.collider != null) {
				timeLookedAt += Time.deltaTime;
				//Debug.Log (name + "  " + timeLookedAt);
				lookingTime = name + " be looked: " + timeLookedAt;
				Debug.Log (lookingTime);
			//}

			// 4. did the Raycast hit this object?
			//if ( myRayHit.collider == GetComponent<Collider>() ) {
		 		// this is up to you... what should we do if we look at it?
		      // 	Debug.Log(myRayHit.collider.name);
//				Debug.Log("raycast hit on " + gameObject.name );
//				timeLookedAt += Time.deltaTime; // "deltaTime" is how long the frame was, after 1 sec it will = 1

			//	if ( timeLookedAt >= 0.5f ) { // did we look for 1+ seconds?
					//	timeLookedAt += Time.deltaTime;
					// now do something? play a sound, play animation, explode, etc....
					//	Destroy( gameObject ); // delete this after 1 second
//					Debug.Log("raycast hit on" +gameObject.name+"for "+ timeLookedAt+" seconds");
			//	}

		//	} 

		} else{

		}
	}
		
}
