using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
	public GameObject Player;
	Vector3 offset;

	void Start ()
	{
		offset = transform.position;
	}

	
}