using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeMoneyScript : MonoBehaviour {

	public GameObject MoneyPerClick; 
	public GameObject Cost; 

	public int clickAmount = 1;
	public int priceUpgrade = 10; 

	void Update(){
		MoneyPerClick.GetComponent<Text>().text = "Money per click: " + clickAmount + "$";
		Cost.GetComponent<Text>().text = "Cost: " + priceUpgrade + "$";
	}

	public void buttonPress(){
		GlobalMoneyCount.MoneyCount += 1 * clickAmount; 
	}

	public void buttonUpgrade(){
		if (GlobalMoneyCount.MoneyCount >= priceUpgrade) {
			GlobalMoneyCount.MoneyCount -= priceUpgrade;
			priceUpgrade += 5;
			clickAmount += 1;
		}
	}
}
