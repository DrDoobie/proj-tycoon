using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	public float money = 0.0f;
	private Text moneyText;

	private void Awake () {
		moneyText = GameObject.FindGameObjectWithTag("MoneyText").GetComponent<Text>();
	}

	private void Update () {
		TextController();
	}

	private void TextController () {
		moneyText.text = "$" + money;
	}

	public void AdjustMoney (bool bol, float value) {
		if(bol)
		{
			money += value;
			return;
		}

		money -= value;
	}
}
