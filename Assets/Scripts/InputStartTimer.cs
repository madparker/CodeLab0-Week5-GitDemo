using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputStartTimer : MonoBehaviour
{

	public Timer timer;
	
	// Use this for initialization
	void Start ()
	{
		timer = GameObject.Find("Cube").GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space))
		{
			timer.Trigger();
		}
	}
}
