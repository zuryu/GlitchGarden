using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] musicList;
	
	private AudioSource audioSource;
	
	void Awake(){
		DontDestroyOnLoad(gameObject);
	}
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level){
		AudioClip levelMusic = musicList[level];
		if(levelMusic){
			audioSource.clip = levelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	
	public void SetVolume(float volume){
		audioSource.volume = volume;
	}
}
