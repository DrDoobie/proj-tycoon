using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	private PlayerStats playerStats;

	private void Awake () {
		playerStats = FindObjectOfType<PlayerStats>();
	}

	public void Buy () {
		playerStats.AdjustMoney(false, 10.0f);
	}

	public void Sell () {
		playerStats.AdjustMoney(true, 10.0f);
	}
}
