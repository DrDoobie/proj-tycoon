using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

	bool uiOpen = false, inRange = false;
	public GameObject uiPanel;
	public string text;
	private GameController gameController;

	private void Awake () {
		gameController = FindObjectOfType<GameController>();
	}

	private void Update () {
		InteractionController();
	}

	private void InteractionController () {
		if(uiOpen)
		{
			uiPanel.SetActive(true);

		} else {
			uiPanel.SetActive(false);
		}

		if(inRange)
		{
			if(Input.GetButtonDown("Interact"))
			{
				gameController.paused = !gameController.paused;
				uiOpen = !uiOpen;
			}

			return;
		}
	}

	private void OnTriggerEnter (Collider other) {
		if(other.tag == "Player")
		{
			inRange = true;
		}
	}

	private void OnTriggerExit (Collider other) {
		if(other.tag == "Player")
		{
			inRange = false;
		}
	}
}
