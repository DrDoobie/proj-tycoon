using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementPrefab : MonoBehaviour {

    public bool isPlaceable;
    public GameObject objPrefab;
    public Material[] material;
    Renderer rend;

	private void Awake () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

        isPlaceable = true;
    }

    private void Update () {
        PlacementController();
    }

    private void PlacementController () {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(objPrefab, transform.parent.position, transform.parent.rotation);
        }

        if(!isPlaceable)
        {
            rend.sharedMaterial = material[1];
            return;
        }

        rend.sharedMaterial = material[0];
    }
}
