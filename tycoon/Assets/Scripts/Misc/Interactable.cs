using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

	public bool uiOpen = false, inRange = false;
	public GameObject uiPanel;
	public string text;
	private GameController gameController;
	private Text interactText;

	private void Awake () {
		gameController = FindObjectOfType<GameController>();
		interactText = GameObject.FindWithTag("InteractText").GetComponent<Text>();
	}

	private void Update () {
		InteractionController();
	}

	private void InteractionController () {
		/*if(uiOpen)
		{
			if(Input.GetButtonDown("Pause"))
			{
				uiOpen = false;
			}

			uiPanel.SetActive(true);

		} else {
			uiPanel.SetActive(false);
		}

		if(inRange && !uiOpen)
		{
			if(Input.GetButtonDown("Interact"))
			{
				uiOpen = !uiOpen;
				gameController.paused = true;
			}

			interactText.text = "'e' to " + text;
			return;
		}

		interactText.text = null; */

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
				uiOpen = !uiOpen;
			}

			interactText.text = "'e' to " + text;
			return;
		}

		interactText.text = null;
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
