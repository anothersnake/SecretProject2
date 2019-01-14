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
	public int upgradePrice = 10; 
	public int baseCost = 10; 
	//constant for testing, need to update in the buttonPress function to calculate the new moneyGenerated value 
	public int baseMoneyGenerated = 2; 
	public int totalMoneyGenerated = 50;
	public float timePerGeneration = 5.0f; 
	public float timeDelay = 5.0f; 

	void Update()
    {
		itemAmountText.GetComponent<Text>().text = "#" + itemAmount; 
		upgradePriceText.GetComponent<Text>().text = "Upgrade: $" + upgradePrice; 
		outputMoneyText.GetComponent<Text> ().text = totalMoneyGenerated + " every x seconds";
    }

	public void buttonPress(){
		if (GlobalMoneyCount.MoneyCount >= upgradePrice) {
			if (itemAmount == 0) {
				InvokeRepeating ("addMoney", timeDelay, timePerGeneration);  
			}
			GlobalMoneyCount.MoneyCount -= upgradePrice; 
			upgradePrice = (int)(baseCost * Mathf.Pow((float)1.07, itemAmount)); 
			itemAmount += 1;
			totalMoneyGenerated += baseMoneyGenerated; 
		} 
		else {
			//do something that tells user they cant click this button
			//noise or bad color or some shit 
		}
	}
	
	void addMoney(){
		GlobalMoneyCount.MoneyCount += totalMoneyGenerated ;			
	}
}
