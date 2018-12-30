using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneDollarButtonSec : MonoBehaviour {

	public  int buttonCount = 1;
	public int buttonPrice = 10;  

	public void buttonPress(){
		if (GlobalMoneyCount.MoneyCount >= buttonPrice) {
			GlobalMoneyCount.MoneyCount -= buttonPrice; 
			buttonCount += 1;
			buttonPrice += 5;
			InvokeRepeating ("OneDollar", 1.0f, 1.0f); 
		}
	}

	void OneDollar(){
		GlobalMoneyCount.MoneyCount += 1;
	}
}
