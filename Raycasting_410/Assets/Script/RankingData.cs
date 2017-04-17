using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;


public class RankingData : MonoBehaviour 
{

	public GameObject wall_1;
	//public this GameObject in the inspector, for later on putting the object which holding the script need to access on it
	private GetTime SecondScriptToAccess; 
	// "getTime" need to be the script's excauate name that need to access.
	// "SecondScriptToAccess" is the variable for holding the component/code accessed from other script.
//	private float wall_1_timeBeLooked;
//	private float wall_2_timeBeLooked;
//	private float wall_3_timeBeLooked;
//	private float wall_4_timeBeLooked;
//	private float ball_1_timeBeLooked;
//	private float ball_2_timeBeLooked;
//	private float ball_3_timeBeLooked;
//	private float ball_4_timeBeLooked;
	public List<float>DataList = new List<float> ();
	// public Text RankedText;
	//public float[] arrayForList  = new float[8];


	void Start () 
	{
		//data getting
		SecondScriptToAccess = wall_1.GetComponent<GetTime> ();

		DataList.Add (SecondScriptToAccess.wall_1_timeLooked);
		DataList.Add (SecondScriptToAccess.wall_2_timeLooked);
		DataList.Add (SecondScriptToAccess.wall_3_timeLooked);
		DataList.Add (SecondScriptToAccess.wall_4_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_1_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_2_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_3_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_4_timeLooked);

	}

	void TimeList()
	{
		DataList[0] = SecondScriptToAccess.wall_1_timeLooked;
		DataList[1] = SecondScriptToAccess.wall_2_timeLooked;
		DataList[2] = SecondScriptToAccess.wall_3_timeLooked;
		DataList[3] = SecondScriptToAccess.wall_4_timeLooked;
		DataList[4] = SecondScriptToAccess.ball_1_timeLooked;
		DataList[5] = SecondScriptToAccess.ball_2_timeLooked;
		DataList[6] = SecondScriptToAccess.ball_3_timeLooked;
		DataList[7] = SecondScriptToAccess.ball_4_timeLooked;

	}
	void Update ()
	{
		TimeList ();

		DataList.Sort ();
//		Debug.Log (DataList);
//		arrayForList [0] = (float)DataList [0];
//		arrayForList [1] = (float)DataList [1];
//		arrayForList [2] = (float)DataList [2];
//		arrayForList [3] = (float)DataList [3];
//		arrayForList [4] = (float)DataList [4];
//		arrayForList [5] = (float)DataList [5];
//		arrayForList [6] = (float)DataList [6];
//		arrayForList [7] = (float)DataList [7];
//
		printOutList ();
//		if (Input.GetKeyDown (KeyCode.A))
//		{
//			RankedTextList ();

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

//	void RankedTextList()
//	{
//		RankedText.text = arrayForList.ToString();
//	}
//

}
