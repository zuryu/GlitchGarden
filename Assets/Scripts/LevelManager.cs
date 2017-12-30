using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public float loadNextLevelAfter;
	
	void Start(){
		if(loadNextLevelAfter >= 0){
			Invoke("LoadNextLevel", loadNextLevelAfter);
		} else {
			Debug.Log("Load next level should be a positive number");
		}
	}

	public void LoadLevel(string name){
		Application.LoadLevel(name);
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void QuitGame(){
		Application.Quit();
	}
}
