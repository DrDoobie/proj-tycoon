using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementPrefab : MonoBehaviour {

    public bool placeable;
    public GameObject objPrefab;
    public Material[] material;
    Renderer rend;

	private void Awake () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    private void Update () {
        PlacementController();
    }

    private void PlacementController () {
        if(!placeable)
        {
            rend.sharedMaterial = material[1];
            return;
        }

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(objPrefab, transform.parent.position, transform.parent.rotation);
        }

        rend.sharedMaterial = material[0];
    }

    private void OnTriggerEnter (Collider other) {
        if(other.gameObject.layer == 9  )
        {
            placeable = false;
            Debug.Log("AWD");
        }
    }
}
