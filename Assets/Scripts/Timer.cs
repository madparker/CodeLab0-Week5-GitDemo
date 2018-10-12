using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

	public float duration = 5;
	float timeElapsed = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeElapsed < duration)
		{
			timeElapsed += Time.deltaTime;
			Debug.Log("Timer is running!");
		}
		else
		{
			Debug.Log("Times up!");
		}
	}
}
