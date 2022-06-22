using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{

	Light lights;

	// Use this for initialization
	void Start()
	{
		lights = GetComponent<Light>();
	}

	// Update is called once per frame
	void Update()
	{
		// Toggle light on/off when L key is pressed.
		if (Input.GetKeyUp(KeyCode.L))
		{
			lights.enabled = !lights.enabled;
		}
	}


}
