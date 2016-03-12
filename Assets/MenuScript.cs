using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	private bool pause = false;

	public void GoToMenu()
	{
		Application.LoadLevel("Main Menu");
	}
	public void GoToHelp()
	{
		Application.LoadLevel("Help Menu");
	}

	public void GoToLevel()
	{
		Application.LoadLevel("Game");

	}
	public void GoToEnd()
	{
		Application.LoadLevel("End Scene");

	}



	
}
