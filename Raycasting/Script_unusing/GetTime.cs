using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// put this script on the thing to be looked at
// do not put on the player or camera!!
public class GetTime : MonoBehaviour {

	public Text timeInfoText;
	public float wall_1_timeLooked = 0f;
	public float wall_2_timeLooked = 0f;
	public float wall_3_timeLooked = 0f;
	public float wall_4_timeLooked = 0f;
	public float ball_1_timeLooked = 0f;
	public float ball_2_timeLooked = 0f;
	public float ball_3_timeLooked = 0f;
	public float ball_4_timeLooked = 0f;
	string hitedObjectName;
	string lookingTime_Wall_1;
	string lookingTime_Wall_2;
	string lookingTime_Wall_3;
	string lookingTime_Wall_4;
	string lookingTime_Ball_1;
	string lookingTime_Ball_2;
	string lookingTime_Ball_3;
	string lookingTime_Ball_4;

	// UI setting
	void SetTextList()
	{
		timeInfoText.text = "Timing List: " +"\n"
			+ lookingTime_Wall_1 + "\n"
			+ lookingTime_Wall_2 +"\n"
			+ lookingTime_Wall_3 +"\n"
			+ lookingTime_Wall_4 +"\n"
			+ lookingTime_Ball_1 +"\n"
			+ lookingTime_Ball_2 +"\n"
			+ lookingTime_Ball_3 +"\n"
			+ lookingTime_Ball_4 +"\n";
	}

	void Start ()
	{
		SetTextList ();	
	}


	void Update () 
	{
		// 1. calculate the Raycast origin and direction
		Ray ray = new Ray( Camera.main.transform.position, Camera.main.transform.forward );
		// 2. setup our RaycastHit riable, reserve memory for it
		RaycastHit myRayHit = new RaycastHit();  // ji cheng gai function's shu xing
		Debug.DrawRay( ray.origin, ray.direction * 50f, Color.yellow );
		SetTextList ();	

		if ( Physics.Raycast( ray, out myRayHit, 50f ) ) 
		{
			
			hitedObjectName = myRayHit.collider.gameObject.name;
			//Debug.Log (hitedObjectName);
			// seperated itmes from here 
			//wall_1
			if(hitedObjectName == "wall_1")
			{
				wall_1_timeLooked += Time.deltaTime;
				lookingTime_Wall_1 = hitedObjectName + " be looked: " + wall_1_timeLooked;
				//Debug.Log (lookingTime_Wall_1);
				SetTextList ();
			}

			//wall_2
			if(hitedObjectName == "wall_2")
			{
				wall_2_timeLooked += Time.deltaTime;
				lookingTime_Wall_2 = hitedObjectName + " be looked: " + wall_2_timeLooked;
				//Debug.Log (lookingTime_Wall_2);
				SetTextList ();
			}
			//wall_3
			if(hitedObjectName == "wall_3")
			{
				wall_3_timeLooked += Time.deltaTime;
				lookingTime_Wall_3 = hitedObjectName + " be looked: " + wall_3_timeLooked;
			//	Debug.Log (lookingTime_Wall_3);
				SetTextList ();
			}
			//wall_4
			if(hitedObjectName == "wall_4")
			{
				wall_4_timeLooked += Time.deltaTime;
				lookingTime_Wall_4 = hitedObjectName + " be looked: " + wall_4_timeLooked;
			//	Debug.Log (lookingTime_Wall_4);
				SetTextList ();
			}

			//ball_1
			if(hitedObjectName == "ball_1")
			{
				ball_1_timeLooked += Time.deltaTime;
				lookingTime_Ball_1 = hitedObjectName + " be looked: " + ball_1_timeLooked;
			//	Debug.Log (lookingTime_Ball_1);
				SetTextList ();
			}
			//ball_2
			if(hitedObjectName == "ball_2")
			{
				ball_2_timeLooked += Time.deltaTime;
				lookingTime_Ball_2 = hitedObjectName + " be looked: " + ball_2_timeLooked;
			//	Debug.Log (lookingTime_Ball_2);
				SetTextList ();
			}

			//ball_3
			if(hitedObjectName == "ball_3")
			{
				ball_3_timeLooked += Time.deltaTime;
				lookingTime_Ball_3 = hitedObjectName + " be looked: " + ball_3_timeLooked;
			//	Debug.Log (lookingTime_Ball_3);
				SetTextList ();
			}

			//ball_4
			if(hitedObjectName == "ball_4")
			{
				ball_4_timeLooked += Time.deltaTime;
				lookingTime_Ball_4 = hitedObjectName + " be looked: " + ball_4_timeLooked;
			//	Debug.Log (lookingTime_Ball_4);
				SetTextList ();
			}

		} 

	}// update‘s bracket
		

} // class' bracket
