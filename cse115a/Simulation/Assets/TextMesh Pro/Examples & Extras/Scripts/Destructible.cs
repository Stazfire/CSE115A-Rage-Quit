using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion; // Reference to the shattered version of the object
	public GameObject iphone;

	bool touching = false;
	private void OnCollisionEnter(Collision collision)
	{
		iphone.SetActive(true);
		touching = true;
	}

	private void OnCollisionExit(Collision collision)
	{
		iphone.SetActive(false);
		touching = false;
	}
	// If the player clicks on the object
	void OnMouseDown ()
	{
		if(touching)
		{
			// Spawn a shattered object
			Instantiate(destroyedVersion, transform.position, transform.rotation);
			// Remove the current object
			Destroy(gameObject);
			iphone.SetActive(false);
			touching = false;
		}
	}

}
