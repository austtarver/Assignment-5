using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
	public Text PanelNameText;
	
	
	public Text PanelRoundsPlayedText;
	

	private void Awake()
	{
		PanelNameText.text = keepData.PlayerName;
		
		PanelRoundsPlayedText.text = "Rounds: " + keepData.PlayerRounds.ToString();
	}


	void Update()
	{
		
	}
	
}

