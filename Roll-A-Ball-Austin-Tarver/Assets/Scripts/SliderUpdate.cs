using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdate : MonoBehaviour
{
	public Slider BallSpeedSlider;
	public Slider targetRotationSlider;
	public Text PanelBallSpeedText;
	public Text targetRotationSpeed;

	public static float TargetRotationSpeed;
	public static float BallSpeedspeed;

    // Update is called once per frame
    void Update()
    {
		TargetRotationSpeed = targetRotationSlider.value;
		targetRotationSpeed.text = "Rotation: " + TargetRotationSpeed;

		BallSpeedspeed = BallSpeedSlider.value;
		PanelBallSpeedText.text = "Ball Speed: " + BallSpeedspeed;
		
    }

	public void TargetUpdate ()
	{
		TargetRotationSpeed = targetRotationSlider.value;
		targetRotationSpeed.text = "Rotation: " + TargetRotationSpeed;

		BallSpeedspeed = BallSpeedSlider.value;
		PanelBallSpeedText.text = "Ball Speed: " + BallSpeedspeed;
	}
}
