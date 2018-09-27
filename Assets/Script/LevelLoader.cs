using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public Slider slider;
	public Text textProgress;

	void Start(){
		LoadScene(1);
	}

	public void LoadScene(int sceneIndex){
		StartCoroutine(LoadAsynchronously(sceneIndex));
	}

	IEnumerator LoadAsynchronously(int sceneIndex){
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

		while (!operation.isDone){
			float progress = Mathf.Clamp01(operation.progress / .9f);
			slider.value = progress;
			textProgress.text = progress * 100f + "%";

			yield return null;
		}
	}
}
