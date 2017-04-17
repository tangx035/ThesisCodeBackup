
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;

public class Call_Gameobject : MonoBehaviour {


	//  public this GameObject in the inspector, for later on putting the object which holding the script need to access on it
	//	public GameObject wall_1;
	public GameObject accessScriptObject_Dunkin;
	// "getTime" need to be the script's excauate name that need to access.
	// "SecondScriptToAccess" is the variable for holding the component/code accessed from other script.
	private GetTimeScript SecondScriptToAccess; 

	//public prefabs
	public GameObject PrefabU_DunkinDonuts;
	public GameObject PrefabU_Google;
	public GameObject PrefabU_CokeCola;
	public GameObject PrefabU_McDonalds;
	public GameObject PrefabU_Chanel;
	public GameObject PrefabU_BurgerKing;
	public GameObject PrefabU_Mms;
	public GameObject PrefabU_TMobile;
	public GameObject PrefabU_Pizza;
	public GameObject PrefabU_Starbucks;
	public GameObject PrefabU_AMC;
	public GameObject prefabLoad;
	public GameObject hold_logo;



	private int     donuts_timeBeLooked;
	private int     google_timeBeLooked;
	private int   cokecola_timeBeLooked;
	private int  mcDonalds_timeBeLooked;
	private int     chanel_timeBeLooked;
	private int burgerKing_timeBeLooked;
	private int        mms_timeBeLooked;
	private int    tMobile_timeBeLooked;
	private int      pizza_timeBeLooked;
	private int  starbucks_timeBeLooked;
	private int        amc_timeBeLooked;

	List<DetectedItems> itemsAttribute = new List<DetectedItems> ();
	public	GameObject[] prefabObjects = new GameObject[11];
	//	GameObject instantiateObject;

	private bool PrintOnce;

	void Start () 
	{
		//data getting
		SecondScriptToAccess = accessScriptObject_Dunkin.GetComponent<GetTimeScript> ();
		IntoInt ();
		ItemsList ();

		prefabObjects[0] = PrefabU_DunkinDonuts;
	//	prefabObjects[0] = Canvas_VR;
		prefabObjects[1] = PrefabU_Google;
		prefabObjects[2] = PrefabU_CokeCola;
		prefabObjects[3] = PrefabU_McDonalds;
		prefabObjects[4] = PrefabU_Chanel;
		prefabObjects[5] = PrefabU_BurgerKing;
		prefabObjects[6] = PrefabU_Mms;
		prefabObjects[7] = PrefabU_TMobile;
		prefabObjects[8] = PrefabU_Pizza;
		prefabObjects[9] = PrefabU_Starbucks;
		prefabObjects[10] = PrefabU_AMC;
	}

	void IntoInt()
	{
		donuts_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.DunkinDonuts_timeLooked); 
		google_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.Google_timeLooked); 
		cokecola_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.CokeCola_timeLooked); 
		mcDonalds_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.McDonalds_timeLooked); 
	//	ball_1_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.Bus_timeLooked); 
		chanel_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.Chanel_timeLooked); 
		burgerKing_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.BurgerKing_timeLooked); 
		mms_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.Mms_timeLooked); 
		tMobile_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.TMobile_timeLooked); 
		pizza_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.Pizza_timeLooked); 
		starbucks_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.Starbucks_timeLooked); 
		amc_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.AMC_timeLooked); 
	}

	void ItemsList()
	{
		itemsAttribute.Add ( new DetectedItems(PrefabU_DunkinDonuts, donuts_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_Google,       google_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_CokeCola,   cokecola_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_McDonalds, mcDonalds_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_Chanel,       chanel_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_BurgerKing,burgerKing_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_Mms,             mms_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_TMobile,     tMobile_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_Pizza,         pizza_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_Starbucks, starbucks_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems(PrefabU_AMC,             amc_timeBeLooked));

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
		//ItemsList (); 
		//sort list "items" according to comparer which called from "DetectedItems.cs"\
		PrintOnce = false;

		if (Input.GetKeyDown (KeyCode.B)) 
		{
			ItemsList (); 
			itemsAttribute.Sort ();
			PrintOnce = true;
		}

		if (PrintOnce == true) {
			PrintItemsTime (); //print out wateched int times in concole
			PrintOnce = false;
	//		itemsAttribute.Clear ();
		}
		if (Input.GetKeyDown (KeyCode.C)) 
		{
			itemsAttribute.Clear ();
		}
		if (Input.GetKeyDown (KeyCode.L)) 
		{
		//	Print itemsAttribute.();
			print(itemsAttribute.Count);
		}
		//GameObject cloneObject = new GameObject();


		//instantiate all objects by two for loops
//		if (Input.GetKeyDown (KeyCode.A)) 
//		{
//			for (int i = 0; i < 11; i++) {
//				for (int j = 0; j < prefabObjects.Length; j++) { 
//					if (prefabObjects[j] == itemsAttribute [i].name) 
//					{
//						Instantiate (prefabObjects[j] );
//
//					}
//				}
//			}
//		}


		if (Input.GetKeyDown (KeyCode.Z)) 
		{
		//  Instantiate (prefabObjects[0]);
	//		prefabObjects[0].transform.parent = test.transform;
			prefabLoad = Instantiate (prefabObjects[0]);
			prefabLoad.transform.parent = hold_logo.transform;
	
		}

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			for (int i = 0; i < 12; i++) {
				if (prefabObjects [i]== itemsAttribute [0].name) {
					Instantiate (prefabObjects [i]);
				}

			}
		}
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			for (int i = 0; i < 12; i++) {
				if (prefabObjects [i]== itemsAttribute [1].name) {
					Instantiate (prefabObjects [i]);
				}

			}
		}
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			for (int i = 0; i < 12; i++) {
				if (prefabObjects [i]== itemsAttribute [2].name) {
					Instantiate (prefabObjects [i]);
				}

			}
		}
	}



}

// GameObject.Find("DoubleRockets").GetComponent("gunscript");
