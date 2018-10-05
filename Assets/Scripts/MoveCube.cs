using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

	public float cubeSpeed = 1.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var position = transform.position;
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.position = position * cubeSpeed * Vector3.up;
		}	
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.position = position * cubeSpeed * Vector3.down;
		}	
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.position = position * cubeSpeed * Vector3.left;
		}	
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.position = position * cubeSpeed * Vector3.right;
		}	
	}
}
