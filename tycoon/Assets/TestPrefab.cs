using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPrefab : MonoBehaviour {

	bool isOpen, inRange;
	public GameObject infoPanel;

	private void Update () {
        PanelController();
    }
	
    private void PanelController () {
        if(inRange)
        {
            if(Input.GetButtonDown("Interact"))
            {
                isOpen = !isOpen;
            }
        }

        if(isOpen)
        {
            infoPanel.SetActive(true);
            return;
        }

        infoPanel.SetActive(false);
    }

    private void OnTriggerEnter (Collider other) {
        inRange = true;
    }

    private void OnTriggerExit (Collider other) {
        inRange = false;

        if(isOpen)
        {
            isOpen = !isOpen;
        }
    }
}
