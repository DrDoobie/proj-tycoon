using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSystem : MonoBehaviour {

	public Camera mainCam;
	public GameObject prefab;

	private void Update () {
		RaycastHit hit;

		if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit))
		{
			prefab.SetActive(true);
			prefab.transform.position = hit.point;
		}
	}
}
