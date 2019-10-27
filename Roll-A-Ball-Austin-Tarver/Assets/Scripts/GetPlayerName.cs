using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetPlayerName : MonoBehaviour
{
	public InputField PlayerName;
	public Text ShowName;

	public void DisplayName()
	{
		ShowName.text = PlayerName.text;
	}
}
