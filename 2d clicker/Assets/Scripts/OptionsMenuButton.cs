using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenuButton : MonoBehaviour
{
	public GameObject OptionsMenu; 
	public GameObject UpgradeMenu;
	public GameObject MainMenu;
	public GameObject AirDancerMenu; 

	bool wasUpgrade ; 
	bool wasMain; 
	bool wasAirDancer; 

	public void toOptions(){
		if (MainMenu.activeInHierarchy) {
			wasMain = true; 
			wasUpgrade = false;
			wasAirDancer = false; 
			OptionsMenu.SetActive (true); 
			MainMenu.SetActive (false); 
		} else if (UpgradeMenu.activeInHierarchy) {
			wasMain = false; 
			wasUpgrade = true;
			wasAirDancer = false; 
			OptionsMenu.SetActive (true); 
			UpgradeMenu.SetActive (false); 
		} else if (AirDancerMenu.activeInHierarchy) {
			wasMain = false; 
			wasUpgrade = false;
			wasAirDancer = true; 
			OptionsMenu.SetActive (true); 
			AirDancerMenu.SetActive (false);
		} 
		else {
			Debug.Log ("toOptions reached an invalid conditional"); 
		}
	}

	public void outOptions(){
		if (wasMain) {
			wasMain = false;
			OptionsMenu.SetActive (false);
			MainMenu.SetActive (true); 
		} else if (wasUpgrade) {
			wasUpgrade = false;
			OptionsMenu.SetActive (false);
			UpgradeMenu.SetActive (true); 
		} else if (wasAirDancer) {
			wasAirDancer = false;
			OptionsMenu.SetActive (false);
			AirDancerMenu.SetActive (true); 
		} else {
			Debug.Log ("outOptions reached an invalid conditional");
		}
	}

}
