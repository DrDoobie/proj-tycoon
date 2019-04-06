using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public bool uiOpen, paused;
	public GameObject uiPanel;

	private void Update () {
		PauseController();
		UIController();
	}

	private void PauseController () {
		if(Input.GetButtonDown("Pause"))
		{
			paused = !paused;
		}

		if(paused)
		{
			CursorLock(false);
			Time.timeScale = 0.0f;
			return;
		}

		CursorLock(true);
		Time.timeScale = 1.0f;
	}

	private void UIController () {
		if(Input.GetButtonDown("UI"))
		{
			uiOpen = !uiOpen;
		}

		if(uiOpen)
		{
			uiPanel.SetActive(true);
			return;
		}

		uiPanel.SetActive(false);
	}

	public void CursorLock (bool bol) {
		if(bol)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			return;
		}

		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
}
