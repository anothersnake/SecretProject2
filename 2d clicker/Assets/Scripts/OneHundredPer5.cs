using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHundredPer5 : MonoBehaviour {

	public  int buttonCount = 1;
	public int buttonPrice = 100;  

	public void buttonPress(){
		if (GlobalMoneyCount.MoneyCount >= buttonPrice) {
			GlobalMoneyCount.MoneyCount -= buttonPrice; 
			buttonCount += 1;
			buttonPrice += 5;
			InvokeRepeating ("OneDollar", 5.0f, 5.0f); 
		}
	}

	void OneDollar(){
		GlobalMoneyCount.MoneyCount += 100;
	}
}
	
