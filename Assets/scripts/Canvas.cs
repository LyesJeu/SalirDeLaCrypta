﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour {
	//écran de départ
	public GameObject ecranDemarrage;

	// Use this for initialization
	void Start () {
		ecranDemarrage.gameObject.SetActive (true);
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void JouerJeu(){
		Debug.Log ("Commencer le jeu");
		ecranDemarrage.gameObject.SetActive (false);
		Time.timeScale = 1;
	}
}