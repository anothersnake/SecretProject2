using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveDollarButton : MonoBehaviour {

	public int buttonCount = 0; 
	public int buttonPrice = 100; 


	public void buttonPress(){
		if (GlobalMoneyCount.MoneyCount >= buttonPrice) {
			GlobalMoneyCount.MoneyCount -= buttonPrice; 
			buttonCount += 1;
			buttonPrice += 20; 
		} 
		else {
			//do something that tells user they cant click this button
			//noise or bad color or some shit 
		}
	}

	void Start() {
		InvokeRepeating ("AddMoney", 1.0f, 1.0f); 
	}

	void AddMoney(){
		GlobalMoneyCount.MoneyCount += 5 * buttonCount; 
	}
}
