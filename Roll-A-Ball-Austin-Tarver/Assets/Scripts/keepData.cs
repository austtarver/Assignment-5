using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// added

//attached to data manager object in all scenes

public class keepData : MonoBehaviour
{
	public static string PlayerName = "Anonymous";
	public static int PlayerRounds;
	public static int PlayerScore;// link to the old game somehow?
	public static int HighScore;
	
	public static int RoundsPlayed;

	public InputField PlayerNameInput;
	public Dropdown PlayerRoundsDropdown;
	// don't forget to fill these fields in the inspector for data manager

	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject); //don't destroy when new scene is loaded
	}
	private void Update()
	{
		
		//Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayerSpeed + " speed and score of " + PlayerScore);
	}
	public void UpdateName()
	{
		PlayerName = PlayerNameInput.text;
	}
	public void SetRounds()
	{
		PlayerRounds = PlayerRoundsDropdown.value;
	}
	


}