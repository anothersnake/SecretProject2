using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour {

	public void playGame(){
		SceneManager.LoadScene ("mainGame"); 
	}

	public void quitGame(){
		
		Application.Quit (); 
	}

}