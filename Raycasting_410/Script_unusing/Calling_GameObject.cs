using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;

public class Calling_GameObject : MonoBehaviour {


	public GameObject wall_2;
	//public this GameObject in the inspector, for later on putting the object which holding the script need to access on it
	private GetTime SecondScriptToAccess; 
	// "getTime" need to be the script's excauate name that need to access.
	// "SecondScriptToAccess" is the variable for holding the component/code accessed from other script.
	private float wall_1_timeBeLooked;
	private float wall_2_timeBeLooked;
	private float wall_3_timeBeLooked;
	private float wall_4_timeBeLooked;
	private float ball_1_timeBeLooked;
	private float ball_2_timeBeLooked;
	private float ball_3_timeBeLooked;
	private float ball_4_timeBeLooked;
	public List<float>DataList = new List<float> ();


	void Start () 
	{
		SecondScriptToAccess = wall_2.GetComponent<GetTime> ();
	//	TimeList ();
//
//		DataList.Add (SecondScriptToAccess.wall_1_timeLooked);
//		DataList.Add (SecondScriptToAccess.wall_2_timeLooked);
//		DataList.Add (SecondScriptToAccess.wall_3_timeLooked);
//		DataList.Add (SecondScriptToAccess.wall_4_timeLooked);
//		DataList.Add (SecondScriptToAccess.ball_1_timeLooked);
//		DataList.Add (SecondScriptToAccess.ball_2_timeLooked);
//		DataList.Add (SecondScriptToAccess.ball_3_timeLooked);
//		DataList.Add (SecondScriptToAccess.ball_4_timeLooked);
//
	}


	void Update ()
	{
		TimeList ();
	if (Input.GetKeyDown(KeyCode.A)) 
		{
//		DataList.Sort();
		Debug.Log (DataList);
//		printOutList ();
//		RankedTextList();

		}
	}


	void TimeList()
	{
		wall_1_timeBeLooked = SecondScriptToAccess.wall_1_timeLooked;
		wall_2_timeBeLooked = SecondScriptToAccess.wall_2_timeLooked;
		wall_3_timeBeLooked = SecondScriptToAccess.wall_3_timeLooked;
		wall_4_timeBeLooked = SecondScriptToAccess.wall_4_timeLooked;
		ball_1_timeBeLooked = SecondScriptToAccess.ball_1_timeLooked;
		ball_2_timeBeLooked = SecondScriptToAccess.ball_2_timeLooked;
		ball_3_timeBeLooked = SecondScriptToAccess.ball_3_timeLooked;
		ball_4_timeBeLooked = SecondScriptToAccess.ball_4_timeLooked;

	}

	void printOutList()
	{
		for (int i = 0; i < 8; i++) {
			Debug.Log (DataList[i]);	
		}

		//		foreach(float myValues in DataList)
		//		{
		//		Debug.Log(myValues);
		//		}
	}


}
