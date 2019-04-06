using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public GameObject ui;
	public string text;
	private Text interactText;

	private void Awake () {
		interactText = GameObject.FindWithTag("InteractText").GetComponent<Text>();
	}

	private void OnTriggerEnter (Collider other) {
		if(other.tag == "Player")
		{
			interactText.text = text;
		}
	}

	private void OnTriggerExit (Collider other) {
		if(other.tag == "Player")
		{
			interactText.text = null;
		}
	}
}
