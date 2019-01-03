using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour
{
	public GameObject itemAmountText; 
	public GameObject upgradePriceText; 
	public GameObject outputMoneyText; 

	public int itemAmount = 0; 
	public int upgradePrice = 1; 
	//constant for testing, need to update in the buttonPress function to calculate the new moneyGenerated value 
	public int moneyGenerated = 50;
	float timePerGeneration = 5.0f; 
	float timeDelay = 5.0f; 

	void Update()
    {
		itemAmountText.GetComponent<Text>().text = "#" + itemAmount; 
		upgradePriceText.GetComponent<Text>().text = "Upgrade: $" + upgradePrice; 
		outputMoneyText.GetComponent<Text> ().text = moneyGenerated + " every x seconds";
    }

	public void buttonPress(){
		if (itemAmount == 0) {
			InvokeRepeating ("addMoney", timeDelay, timePerGeneration);  
		}
		if (GlobalMoneyCount.MoneyCount >= upgradePrice) {
			GlobalMoneyCount.MoneyCount -= upgradePrice; 
			itemAmount += 1;
			//Do formula stuff here 
			upgradePrice += 20; 
		} 
		else {
			//do something that tells user they cant click this button
			//noise or bad color or some shit 
		}
	}
	
	void addMoney(){
		GlobalMoneyCount.MoneyCount += moneyGenerated;			
	}
}
