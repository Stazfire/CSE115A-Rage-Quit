using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
	public GameObject open;
	public GameObject pc;

	bool touching = false;
	string tag = "";

	private void OnCollisionEnter(Collision collision)
	{
		tag = collision.gameObject.tag;
		switch(tag)
		{
			case "Door":
				open.SetActive(true);
				touching = true;
				break;
			case "PC":
				pc.SetActive(true);
				touching = true;
				break;
		}
		
	}

	private void OnCollisionExit(Collision collision)
	{
		tag = collision.gameObject.tag;
		switch (tag)
		{
			case "Door":
				open.SetActive(false);
				tag = "";
				touching = false;
				break;
			case "PC":
				pc.SetActive(false);
				tag = "";
				touching = false;
				break;
		}
	}

	private void Update()
	{
		Debug.Log(tag);
		if (touching && Input.GetMouseButtonDown(0))
		{
			switch (tag)
			{
				case "Door":
					Debug.Log("Open Door");
					break;
				case "PC":
					Debug.Log("PC");
					break;
			}
		}
	}
}
