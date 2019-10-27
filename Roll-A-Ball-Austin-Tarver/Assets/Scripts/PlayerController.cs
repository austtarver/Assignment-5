using UnityEngine;
using System;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
	public float speed;
	public Text PanelscoreText;
	private int count = 0;
	public Text WinText;
	public Text text;
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		float x = SliderUpdate.BallSpeedspeed;

		Vector3 movement = new Vector3( x* moveHorizontal,  0.0f,  x* moveVertical);

		GetComponent<Rigidbody>().AddForce( movement *  speed * Time.deltaTime);
		keepData.PlayerScore = count;
		
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count += 1;
			PanelscoreText.text = "Score: " + count;
			if (count >= 8)
			{
				WinText.gameObject.SetActive(true);
			}
		}
	}
}
