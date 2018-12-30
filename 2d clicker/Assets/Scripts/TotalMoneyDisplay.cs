using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalMoneyDisplay : MonoBehaviour
{
	public GameObject totalMoneyDisplayText; 

	void Update(){
		totalMoneyDisplayText.GetComponent<Text> ().text = "" + GlobalMoneyCount.MoneyCount; 
	}
}

