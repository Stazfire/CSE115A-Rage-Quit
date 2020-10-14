using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
	public Animator transition;
	public float transitionTime = 1f;

    public void startGame()
	{
		StartCoroutine(loadLevel());
	}

	IEnumerator loadLevel()
	{
		transition.SetTrigger("Start");

		//wait
		yield return new WaitForSeconds(transitionTime);

		SceneManager.LoadScene("main");
	}
}
