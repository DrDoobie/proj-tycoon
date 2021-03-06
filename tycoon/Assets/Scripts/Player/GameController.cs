﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[HideInInspector] public bool paused, buildMode;

	private void Update () {
		PauseController();
		BuildController();
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

	private void BuildController () {
		if(Input.GetButtonDown("Build Mode"))
		{
			buildMode = !buildMode;
		}
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
