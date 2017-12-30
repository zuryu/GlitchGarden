﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume(float volume){
		if (volume >= 0f && volume <= 1f){
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError("Master volume out of range");
		}
	}
	
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}
	
	public static void UnlockLevel(int level){
		if (level <= Application.levelCount - 1){
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // 1 is true
		} else {
			Debug.Log ("Trying to unlock level not in build order");
		}
	}
	
	public static bool IsLevelUnlocked(int level){
		if (level <= Application.levelCount - 1){
			return PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()) == 1;
		} else {
			Debug.LogError("Trying to check status of level that's not in the build order");
			return false;
		}
	}
	
	public static void SetDifficulty(float difficulty){
		if (difficulty >= 1f && difficulty <= 3f){
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("Difficulty out of range");
		}
	}
	
	public static float GetDifficulty(){
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
}
