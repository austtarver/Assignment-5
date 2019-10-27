using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		float m = SliderUpdate.TargetRotationSpeed;
		transform.Rotate (new Vector3(m* 15, m* 30, m* 45) * Time.deltaTime);
    }
}
