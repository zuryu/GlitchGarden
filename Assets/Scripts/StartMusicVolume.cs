﻿using UnityEngine;
using System.Collections;

public class StartMusicVolume : MonoBehaviour {

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = FindObjectOfType<MusicManager>();
		musicManager.SetVolume(PlayerPrefsManager.GetMasterVolume());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
