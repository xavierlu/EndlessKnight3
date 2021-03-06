﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Shop : MonoBehaviour {
	int gamePiece = 0;
	public Canvas confirmCanvas;
	public Text confirmText, coinText;
	public Button backButton;
	public TileMap tm;

	void Start()
	{
		coinText.text = ""+PlayerPrefs.GetInt("Coins");
	}

	public void PlayAd(){
		DateTime now = DateTime.UtcNow;
		PlayerPrefs.SetString ("LastTimePlayedAd",now.ToString());
		PlayerPrefs.SetInt ("Coins",PlayerPrefs.GetInt("Coins")+20);
	}

	public void BuyWhiteKnight(){
		PlayerPrefs.SetInt ("SelectedGamePiece",0);
	}

	public void BuyCube(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("cube"))
			PlayerPrefs.SetInt ("SelectedGamePiece",1);
		else if (!TorF)
			Confirm (100,1); 
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",1);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"cube");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyPlant(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("plant"))
			PlayerPrefs.SetInt ("SelectedGamePiece",2);
		else if (!TorF)
			Confirm (100,2);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",2);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"plant");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyBook(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("book"))
			PlayerPrefs.SetInt ("SelectedGamePiece",3);
		else if (!TorF)
			Confirm (100,3);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",3);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"book");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyPostBox(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("postbox"))
			PlayerPrefs.SetInt ("SelectedGamePiece",4);
		else if (!TorF)
			Confirm (100,4);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",4);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"postbox");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyGuitar(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("guitar"))
			PlayerPrefs.SetInt ("SelectedGamePiece",5);
		else if (!TorF)
			Confirm (100,5);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",5);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"guitar");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyGasBottle(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("gasbottle"))
			PlayerPrefs.SetInt ("SelectedGamePiece",6);
		else if (!TorF)
			Confirm (100,6);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",6);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"gasbottle");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyToilet(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("toilet"))
			PlayerPrefs.SetInt ("SelectedGamePiece",7);
		else if (!TorF)
			Confirm (100,7);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
			PlayerPrefs.SetInt ("SelectedGamePiece",7);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"toilet");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyVendingMachine(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("vendingmachine"))
			PlayerPrefs.SetInt ("SelectedGamePiece",8);
		else if (!TorF)
			Confirm (100,8);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
			PlayerPrefs.SetInt ("SelectedGamePiece",8);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"vendingmachine");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyKnuckle(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("knuckle"))
			PlayerPrefs.SetInt ("SelectedGamePiece",9);
		else if (!TorF)
			Confirm (100,9);
		else {
		if (PlayerPrefs.GetInt ("Coins") >= 100) {
			PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
			PlayerPrefs.SetInt ("SelectedGamePiece",9);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"knuckle");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}
	
	public void BuyWrench(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("wrench"))
			PlayerPrefs.SetInt ("SelectedGamePiece",10);
		else if (!TorF)
			Confirm (100,10);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
			PlayerPrefs.SetInt ("SelectedGamePiece",10);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"wrench");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyPiano(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("piano"))
			PlayerPrefs.SetInt ("SelectedGamePiece",16);
		else if (!TorF)
			Confirm (115,16);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 115) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-115);
				PlayerPrefs.SetInt ("SelectedGamePiece",16);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"piano");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyBathTube(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("bathtub"))
			PlayerPrefs.SetInt ("SelectedGamePiece",11);
		else if (!TorF)
			Confirm (175,11);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 175) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-175);
				PlayerPrefs.SetInt ("SelectedGamePiece",11);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"bathtub");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyPrinter(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("printer"))
			PlayerPrefs.SetInt ("SelectedGamePiece",12);
		else if (!TorF)
			Confirm (100,12);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",12);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"printer");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyChest(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("chest"))
			PlayerPrefs.SetInt ("SelectedGamePiece",13);
		else if (!TorF)
			Confirm (225,13);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 225) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") - 225);
				PlayerPrefs.SetInt ("SelectedGamePiece", 13);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"chest");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}
	
	public void BuyExtinguisher(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("extinguisher"))
			PlayerPrefs.SetInt ("SelectedGamePiece",14);
		else if (!TorF)
			Confirm(200,14);
		else{
			if (PlayerPrefs.GetInt ("Coins") >= 200) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-200);
				PlayerPrefs.SetInt ("SelectedGamePiece",14);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"extinguisher");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}
	
	public void BuySlotMachine(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("slotmachine"))
			PlayerPrefs.SetInt ("SelectedGamePiece",15);
		else if (!TorF)
			Confirm(200,15);
		else{
			if (PlayerPrefs.GetInt ("Coins") >= 200) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-200);
				PlayerPrefs.SetInt ("SelectedGamePiece",15);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"slotmachine");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyBillBoard(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("billboard"))
			PlayerPrefs.SetInt ("SelectedGamePiece",15);
		else if (!TorF)
			Confirm(9999,17);
		else{
			if (PlayerPrefs.GetInt ("Coins") >= 9999) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-9999);
				PlayerPrefs.SetInt ("SelectedGamePiece",17);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"billboard");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuySodaCan(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("sodacan"))
			PlayerPrefs.SetInt ("SelectedGamePiece",18);
		else if (!TorF)
			Confirm (100,18);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",18);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"sodacan");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void BuyAndroidRobot(bool TorF){
		if (PlayerPrefs.GetString("BroughtGamePiece").Contains("android"))
			PlayerPrefs.SetInt ("SelectedGamePiece",19);
		else if (!TorF)
			Confirm (100,19);
		else {
			if (PlayerPrefs.GetInt ("Coins") >= 100) {
				PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt("Coins")-100);
				PlayerPrefs.SetInt ("SelectedGamePiece",19);
				PlayerPrefs.SetString("BroughtGamePiece",PlayerPrefs.GetString("BroughtGamePiece")+"android");
				coinText.text = ""+PlayerPrefs.GetInt("Coins");
			}
		}
	}

	public void Confirm(int num, int gameP){
		backButton.enabled = false;
		backButton.image.enabled = false;
		confirmCanvas.enabled = true;
		confirmText.text = "¢" + num + "?";
		gamePiece = gameP;
	}

	public void click(bool TorF){
		if (TorF) {
			switch(gamePiece){
			case 0:
				BuyWhiteKnight();
				break;
			case 1:
				BuyCube(true);
				break;
			case 2:
				BuyPlant(true);
				break;
			case 3:
				BuyBook(true);
				break;
			case 4:
				BuyPostBox(true);
				break;
			case 5:
				BuyGuitar(true);
				break;
			case 6:
				BuyGasBottle(true);
				break;
			case 7:
				BuyToilet(true);
				break;
			case 8:
				BuyVendingMachine(true);
				break;
			case 9:
				BuyKnuckle(true);
				break;
			case 10:
				BuyWrench(true);
				break;
			case 11:
				BuyBathTube(true);
				break;
			case 12:
				BuyPrinter(true);
				break;
			case 13:
				BuyChest(true);
				break;
			case 14:
				BuyExtinguisher(true);
				break;
			case 15:
				BuySlotMachine(true);
				break;
			case 16:
				BuyPiano(true);
				break;
			case 17:
				BuyBillBoard(true);
				break;
			case 18:
				BuySodaCan(true);
				break;
			case 19:
				BuyAndroidRobot(true);
				break;
			}		
		}
		confirmCanvas.enabled = false;
		backButton.enabled = true;
		backButton.image.enabled = true;
	} 

	void OnDestroy(){
		PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins"));
	}
}