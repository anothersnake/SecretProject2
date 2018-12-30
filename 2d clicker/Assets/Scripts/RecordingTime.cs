using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System; 

public class RecordingTime : MonoBehaviour {

	DateTime currentDate; 
	DateTime oldDate; 
	long temp; 
	public Text textSomething; 


	//notes from last time
	//start runs after pause on starting app 
	//trying to find a way to use pause to run only when app is closed, and not when app is 
	//opened to log datetime to calculate stuff 
	void Start(){
		temp = Convert.ToInt64(PlayerPrefs.GetString ("dateString"));
		oldDate = DateTime.FromBinary (temp); 
		currentDate = System.DateTime.Now;
		TimeSpan difference = currentDate.Subtract (oldDate); 
		textSomething.text = "Time difference is " + difference.TotalSeconds; 
		int seconds = (int) difference.TotalSeconds;
		//multiply seconds by some money calculation 


	}
	void OnApplicationQuit(){
		PlayerPrefs.SetString("dateString" , System.DateTime.Now.ToBinary().ToString());
	}
}
