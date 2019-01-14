using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoneyCount : MonoBehaviour {

	public static int MoneyCount;
	public GameObject MoneyDisplayAirDancer;
	public GameObject MoneyDisplayUpgrade; 
	public int InternalMoney ; 

	// Update is called once per frame
	void Update () {
		InternalMoney = MoneyCount; 
		if (MoneyDisplayAirDancer.activeInHierarchy) {
			MoneyDisplayAirDancer.GetComponent<Text> ().text = "$ " + InternalMoney; 
		} else if (MoneyDisplayUpgrade.activeInHierarchy) {
			MoneyDisplayUpgrade.GetComponent<Text> ().text = "$ " + InternalMoney; 
		}
	}
}
