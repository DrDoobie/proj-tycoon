using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPrefab : MonoBehaviour {

	bool isOpen;
	public GameObject infoPanel;

	private void Update () {
        PanelController();
    }
	
    private void PanelController () {
        if(isOpen)
        {
            infoPanel.SetActive(true);
            return;
        }

        infoPanel.SetActive(false);
    }
}
