using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPrefab : MonoBehaviour {

	public bool testBool;
	public GameObject infoPanel;

	private void Update () {
        NewMethod();
    }

    private void NewMethod () {
        if(testBool)
        {
            infoPanel.SetActive(true);
            return;
        }

        infoPanel.SetActive(false);
    }
}
