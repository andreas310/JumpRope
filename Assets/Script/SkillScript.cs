using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SkillScript : MonoBehaviour {

	public GameObject LoadingScreen;
	public Slider slider;
	public Text textProgress;
	public AudioSource sourceAudio;
	public TextMeshProUGUI textCoin;
	public GameObject getTap;
	public GameObject getDouble1;
	public GameObject getDouble2;
	int coin;

	// Use this for initialization
	void Start () {
		//set coin
		coin = PlayerPrefs.GetInt("Coin");
		textCoin.text = coin.ToString();

		//music
		sourceAudio.volume = PlayerPrefs.GetFloat("Volume");
		if(PlayerPrefs.GetInt("Music") == 2){
			sourceAudio.Pause();
		}

	}
	
	// Update is called once per frame
	void Update () {


		if(PlayerPrefs.GetString("Tier") == "Silver"){
			getDouble2.SetActive(false);
		}
		else if(PlayerPrefs.GetString("Tier") == "Gold"){
			getDouble2.SetActive(false);
		}
		else if(PlayerPrefs.GetString("Tier") == "Platinum"){
			
		}
		else if(PlayerPrefs.GetString("Tier") == "Chaos"){
			
		}
		else{
			getDouble1.SetActive(false);
			getDouble2.SetActive(false);
		}

		//backbutton mobile
		if (Input.GetKeyDown(KeyCode.Escape)) { LoadScene(1); }
		
	}


	public void LoadScene(int sceneIndex){
		StartCoroutine(LoadAsynchronously(sceneIndex));
	}

	IEnumerator LoadAsynchronously(int sceneIndex){
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

		LoadingScreen.SetActive(true);

		while (!operation.isDone){
			float progress = Mathf.Clamp01(operation.progress / .9f);
			slider.value = progress;
			textProgress.text = progress * 100f + "%";

			yield return null;
		}
	}
}
