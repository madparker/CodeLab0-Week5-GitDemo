using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Timer : MonoBehaviour
{

	public float duration = 7;
	public bool activated = false;
	
	float timeElapsed = 0;
	
	
	// Use this for initialization
	void Start () {
		
	}

	public void Trigger()
	{
		activated = true;
		timeElapsed = 0;
	}

	void WhileTimerRunning()
	{
		Debug.Log("Timer is running: " + timeElapsed);
	}

	// Update is called once per frame
	void Update () {
		if (activated)
		{
			if (timeElapsed < duration)
			{
				timeElapsed += Time.deltaTime;
				WhileTimerRunning();
			}
			else
			{
				StopTimer();
			}
		}
	}

	void StopTimer()
	{
		Debug.Log("Times up!");
		activated = false;
		timeElapsed = 0;
	}
}
