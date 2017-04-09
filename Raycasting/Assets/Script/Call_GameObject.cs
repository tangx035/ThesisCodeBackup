using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;


public class Call_GameObject : MonoBehaviour {
//	public GameObject wall_1;
	public GameObject wall_2;
//	public GameObject wall_3;
//	public GameObject wall_4;
	//public this GameObject in the inspector, for later on putting the object which holding the script need to access on it
	private GetTime SecondScriptToAccess; 
	// "getTime" need to be the script's excauate name that need to access.
	// "SecondScriptToAccess" is the variable for holding the component/code accessed from other script.

	private int wall_1_timeBeLooked;
	private int wall_2_timeBeLooked;
	private int wall_3_timeBeLooked;
	private int wall_4_timeBeLooked;
	private int ball_1_timeBeLooked;
	private int ball_2_timeBeLooked;
	private int ball_3_timeBeLooked;
	private int ball_4_timeBeLooked;
//	public float[] TimeGetted = new float[8];
//	public string[] objectName = new string[8];
//	private int[] sumObject = new int[8];
	List<DetectedItems> items = new List<DetectedItems> ();
	void Start () 
	{
		//data getting
		SecondScriptToAccess = wall_2.GetComponent<GetTime> ();
		//TimeList();
		IntoInt();



	}

	void Update ()
	{
		IntoInt ();
		ItemsList ();
		items.Sort ();
		foreach (DetectedItems eachItems in items) 
		{
			print (eachItems.name + " " + eachItems.time);
		}
		items.Clear();
	}

	void ItemsList()
	{
		items.Add ( new DetectedItems("wall_1",wall_1_timeBeLooked));
		items.Add ( new DetectedItems("wall_2",wall_2_timeBeLooked));
		items.Add ( new DetectedItems("wall_3",wall_3_timeBeLooked));
		items.Add ( new DetectedItems("wall_4",wall_4_timeBeLooked));
		items.Add ( new DetectedItems("ball_1",ball_1_timeBeLooked));
		items.Add ( new DetectedItems("ball_2",ball_2_timeBeLooked));
		items.Add ( new DetectedItems("ball_3",ball_3_timeBeLooked));
		items.Add ( new DetectedItems("ball_4",ball_4_timeBeLooked));
//				items.Add ( new DetectedItems("wall_1",9));
//				items.Add ( new DetectedItems("wall_2",7));
//				items.Add ( new DetectedItems("wall_3",6));
//				items.Add ( new DetectedItems("wall_4",5));
//				items.Add ( new DetectedItems("ball_1",4));
//				items.Add ( new DetectedItems("ball_2",3));
//				items.Add ( new DetectedItems("ball_3",2));
//				items.Add ( new DetectedItems("ball_4",1));

	}

	void IntoInt()
	{
		wall_1_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_1_timeLooked); 
		wall_2_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_2_timeLooked); 
		wall_3_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_3_timeLooked); 
		wall_4_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_4_timeLooked); 
		ball_1_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_1_timeLooked); 
		ball_2_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_2_timeLooked); 
		ball_3_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_3_timeLooked); 
		ball_4_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_4_timeLooked); 

		
	}



//
//	void TimeList() 
//	{
//		// setting items' been looked time into array's index
//		TimeGetted[0] = SecondScriptToAccess.wall_1_timeLooked;
//		TimeGetted[1] = SecondScriptToAccess.wall_2_timeLooked;
//		TimeGetted[2] = SecondScriptToAccess.wall_3_timeLooked;
//		TimeGetted[3] = SecondScriptToAccess.wall_4_timeLooked;
//		TimeGetted[4] = SecondScriptToAccess.ball_1_timeLooked;
//		TimeGetted[5] = SecondScriptToAccess.ball_2_timeLooked;
//		TimeGetted[6] = SecondScriptToAccess.ball_3_timeLooked;
//		TimeGetted[7] = SecondScriptToAccess.ball_4_timeLooked;
//
//	}
//	void objectNameList()
//	{
//		objectName[0]= SecondScriptToAccess.wall_1_timeLooked+ "wall_1";
//		objectName[1]= SecondScriptToAccess.wall_2_timeLooked+ "wall_2";
//		objectName[2]= SecondScriptToAccess.wall_3_timeLooked+ "wall_3";
//		objectName[3]= SecondScriptToAccess.wall_4_timeLooked+ "wall_4";
//		objectName[4]= SecondScriptToAccess.ball_1_timeLooked+ "ball_1";
//		objectName[5]= SecondScriptToAccess.ball_2_timeLooked+ "ball_2";
//		objectName[6]= SecondScriptToAccess.ball_3_timeLooked+ "ball_3";
//		objectName[7]= SecondScriptToAccess.ball_4_timeLooked+ "ball_4";
//
//	
//	}
//
//	void Update ()
//	{
//		TimeList (); 
//		objectNameList();
//		Array.Sort (TimeGetted);
////		Array.Sort (objectName);
//		printOutList ();  //see sorted timeList in console
///		printOutName(); //sored only according to the first digital number??????
//	}
//
//
//	void printOutList()
//	{
//		for (int i = 0; i < 8; i++) 
//		{
//			Debug.Log (TimeGetted[i]);	
//		}
//			
//	}
//
//	void printOutName()
//	{
//		for (int i = 0; i < 8; i++) 
//		{
//			Debug.Log (objectName[i]);	
//		}
//
//	}
//
//	void index_function()
//	{
//		for (int i = 0; i < 8; i++) 
//		{
//			TimeGetted[i] = sumObject [i];
//			objectName[i] = sumObject [i];
//			
//		}
//	}
//		
//
}





//reference in case
/* 

//*
//foreach(float myValues in DataList)
//		{
//		Debug.Log(myValues);
//		}
//
//
//*
//if (Input.GetKeyDown (KeyCode.A))
//{
//	RankedTextList ();
//}
//
//
//
//
//
//
//
//*/