using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;


public class Call_GameObject : MonoBehaviour 
{
//  public this GameObject in the inspector, for later on putting the object which holding the script need to access on it
//	public GameObject wall_1;
	public GameObject wall_2;
    // "getTime" need to be the script's excauate name that need to access.
	// "SecondScriptToAccess" is the variable for holding the component/code accessed from other script.
	private GetTime SecondScriptToAccess; 

	//public prefabs
	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject prefab4;
	public GameObject prefab5;
	public GameObject prefab6;
	public GameObject prefab7;
	public GameObject prefab8;

    private int wall_1_timeBeLooked;
	private int wall_2_timeBeLooked;
	private int wall_3_timeBeLooked;
	private int wall_4_timeBeLooked;
	private int ball_1_timeBeLooked;
	private int ball_2_timeBeLooked;
	private int ball_3_timeBeLooked;
	private int ball_4_timeBeLooked;
	List<DetectedItems> itemsAttribute = new List<DetectedItems> ();
	public	GameObject[] prefabObjects = new GameObject[8];
	GameObject instantiateObject;

	void Start () 
	{
		//data getting
		SecondScriptToAccess = wall_2.GetComponent<GetTime> ();
		IntoInt ();
		ItemsList ();

		prefabObjects[0] = prefab1;
		prefabObjects[1] = prefab2;
		prefabObjects[2] = prefab3;
		prefabObjects[3] = prefab4;
		prefabObjects[4] = prefab5;
		prefabObjects[5] = prefab6;
		prefabObjects[6] = prefab7;
		prefabObjects[7] = prefab8;

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

	void ItemsList()
	{
		itemsAttribute.Add ( new DetectedItems("prefab1",wall_1_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("prefab2",wall_2_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("prefab3",wall_3_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("prefab4",wall_4_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("prefab5",ball_1_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("prefab6",ball_2_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("prefab7",ball_3_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("prefab8",ball_4_timeBeLooked));
	}

	void PrintItemsTime()
	{
		foreach (DetectedItems eachItems in itemsAttribute) 
		{
			print (eachItems.name + ": " + eachItems.time);
		}
		//itemsAttribute.Clear();
	}
		

	void Update ()
	{
		//call IntoInt function to change all float numbers into integer
		IntoInt ();
		// add items into list with name and int time number init
		ItemsList ();
		//sort list "items" according to comparer which called from "DetectedItems.cs"
		itemsAttribute.Sort ();
     	PrintItemsTime (); //print out wateched int times in concole
		//GameObject cloneObject = new GameObject();
		if (Input.GetKeyDown (KeyCode.A)) {
			for (int i = 0; i < 8; i++) {
				for (int j = 0; j < prefabObjects.Length; j++) { 
					if (prefabObjects [j].name == itemsAttribute [i].name) {
						instantiateObject = prefabObjects [j];
						Instantiate (instantiateObject);

					}
				}
			}
		}
	}
		

}