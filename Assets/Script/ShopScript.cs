using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour {

	public GameObject LoadingScreen;
	public GameObject scrollObject;
	public Slider slider;
	public Text textProgress;
	public AudioSource sourceAudio;
	public TextMeshProUGUI textCoin;
	public Animator tierAnim;
	public Image getTier;
	public GameObject tierGameobject;
	public Sprite silver;
	public Sprite gold;
	public Sprite platinum;
	public Sprite chaos;
	public GameObject natsuki;
	public GameObject wizard;
	public GameObject panda;
	public GameObject zelda;
	public GameObject goku;
	public GameObject indiana;
	public GameObject malangan;
	public GameObject darthvader;
	public GameObject paladin;
	public Animator unlockNatsuki;
	public Animator unlockWizard;
	public Animator unlockPanda;
	public Animator unlockZelda;
	public Animator unlockGoku;
	public Animator unlockIndiana;
	public Animator unlockMalangan;
	public Animator unlockDarthvader;
	public Animator unlockPaladin;
	public GameObject riverside;
	public GameObject beach;
	public GameObject mountain;
	public GameObject egypt;
	public GameObject desert;
	public Animator unlockRiverside;
	public Animator unlockBeach;
	public Animator unlockMountain;
	public Animator unlockEgypt;
	public Animator unlockDesert;
	
	string tier;
	int coin;


	// Use this for initialization
	void Start () {
		coin = PlayerPrefs.GetInt("Coin");
		textCoin.text = coin.ToString();
		if(PlayerPrefs.GetInt("Music") == 2){
			sourceAudio.Pause();
		}
		sourceAudio.volume = PlayerPrefs.GetFloat("Volume");

	
	}
	
	// Update is called once per frame
	void Update () {
		//backbutton mobile
		if (Input.GetKeyDown(KeyCode.Escape)) { LoadScene(1); }

		//set tier
		if(PlayerPrefs.GetString("Tier") == "Silver"){
			getTier.sprite = gold;
			wizard.SetActive(true);
			panda.SetActive(true);
			zelda.SetActive(false);
			goku.SetActive(false);
			indiana.SetActive(false);
			malangan.SetActive(false);
			darthvader.SetActive(false);
			paladin.SetActive(false);
			riverside.SetActive(true);
			beach.SetActive(true);
			mountain.SetActive(false);
			egypt.SetActive(false);
			desert.SetActive(false);
		}
		else if(PlayerPrefs.GetString("Tier") == "Gold"){
			getTier.sprite = platinum;
			wizard.SetActive(true);
			panda.SetActive(true);
			zelda.SetActive(true);
			goku.SetActive(true);
			indiana.SetActive(false);
			malangan.SetActive(false);
			darthvader.SetActive(false);
			paladin.SetActive(false);
			riverside.SetActive(true);
			beach.SetActive(true);
			mountain.SetActive(true);
			egypt.SetActive(false);
			desert.SetActive(false);
		}
		else if(PlayerPrefs.GetString("Tier") == "Platinum"){
			getTier.sprite = chaos;
			wizard.SetActive(true);
			panda.SetActive(true);
			zelda.SetActive(true);
			goku.SetActive(true);
			indiana.SetActive(true);
			malangan.SetActive(true);
			darthvader.SetActive(false);
			paladin.SetActive(false);
			riverside.SetActive(true);
			beach.SetActive(true);
			mountain.SetActive(true);
			egypt.SetActive(true);
			desert.SetActive(false);
		}
		else if(PlayerPrefs.GetString("Tier") == "Chaos"){
			tierGameobject.SetActive(false);
			wizard.SetActive(true);
			panda.SetActive(true);
			zelda.SetActive(true);
			goku.SetActive(true);
			indiana.SetActive(true);
			malangan.SetActive(true);
			darthvader.SetActive(true);
			paladin.SetActive(true);
			riverside.SetActive(true);
			beach.SetActive(true);
			mountain.SetActive(true);
			egypt.SetActive(true);
			desert.SetActive(true);
		}
		else{
			wizard.SetActive(false);
			panda.SetActive(false);
			zelda.SetActive(false);
			goku.SetActive(false);
			indiana.SetActive(false);
			malangan.SetActive(false);
			darthvader.SetActive(false);
			paladin.SetActive(false);
			riverside.SetActive(true);
			beach.SetActive(false);
			mountain.SetActive(false);
			egypt.SetActive(false);
			desert.SetActive(false);
		}

		//set Unlock
		if (PlayerPrefs.GetInt("Natsuki") == 1){
			unlockNatsuki.SetTrigger("Natsuki_U");
		}
		if (PlayerPrefs.GetInt("Wizard") == 1){
			unlockWizard.SetTrigger("Wizard_U");
		}
		if (PlayerPrefs.GetInt("Panda") == 1){
			unlockPanda.SetTrigger("Panda_U");
		}
		if (PlayerPrefs.GetInt("Zelda") == 1){
			unlockZelda.SetTrigger("Zelda_U");
		}
		if (PlayerPrefs.GetInt("Goku") == 1){
			unlockGoku.SetTrigger("Goku_U");
		}
		if (PlayerPrefs.GetInt("Indiana") == 1){
			unlockIndiana.SetTrigger("Indiana_U");
		}
		if (PlayerPrefs.GetInt("Malangan") == 1){
			unlockMalangan.SetTrigger("Malangan_U");
		}
		if (PlayerPrefs.GetInt("Darthvader") == 1){
			unlockDarthvader.SetTrigger("Darthvader_U");
		}
		if (PlayerPrefs.GetInt("Paladin") == 1){
			unlockPaladin.SetTrigger("Paladin_U");
		}
		if (PlayerPrefs.GetInt("Beach") == 1){
			unlockBeach.SetTrigger("Beach_U");
		}
		if (PlayerPrefs.GetInt("Riverside") == 1){
			unlockRiverside.SetTrigger("Riverside_U");
		}
		if (PlayerPrefs.GetInt("Mountain") == 1){
			unlockMountain.SetTrigger("Mountain_U");
		}
		if (PlayerPrefs.GetInt("Egypt") == 1){
			unlockEgypt.SetTrigger("Egypt_U");
		}
		if (PlayerPrefs.GetInt("Desert") == 1){
			unlockDesert.SetTrigger("Desert_U");
		}


		//scroll pembatas
		if (scrollObject.transform.position.y > 95){
			scrollObject.transform.position = new Vector3(transform.position.x, 94, transform.position.z);
		}
		if (scrollObject.transform.position.y < -1){
			scrollObject.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
		}


		
	}


	public void buyChara(string chara){
		if(chara == "Tommy"){
			if(coin > 0){
				PlayerPrefs.SetString("CH","CH1");
			}
			else{
				Debug.Log("Coin tidak mencukupi");
			}
		}
		if(chara == "Natsuki"){
			if (PlayerPrefs.GetInt("Natsuki") == 1){
				PlayerPrefs.SetString("CH","CH2");
			}
			else{
				if(coin > 400){
					coin -= 400;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH2");
					PlayerPrefs.SetInt("Natsuki", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(chara == "Wizard"){
			if (PlayerPrefs.GetInt("Wizard") == 1){
				PlayerPrefs.SetString("CH","CH3");
			}
			else{
				if(coin > 800){
					coin -= 800;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH3");
					PlayerPrefs.SetInt("Wizard", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(chara == "Panda"){
			if (PlayerPrefs.GetInt("Panda") == 1){
				PlayerPrefs.SetString("CH","CH4");
			}
			else{
				if(coin > 850){
					coin -= 850;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH4");
					PlayerPrefs.SetInt("Panda", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}	
			}
		}
		if(chara == "Zelda"){
			if (PlayerPrefs.GetInt("Zelda") == 1){
				PlayerPrefs.SetString("CH","CH5");
			}
			else{
				if(coin > 950){
					coin -= 950;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH5");
					PlayerPrefs.SetInt("Zelda", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(chara == "Goku"){
			if (PlayerPrefs.GetInt("Goku") == 1){
				PlayerPrefs.SetString("CH","CH6");
			}
			else{
				if(coin > 950){
					coin -= 950;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH6");
					PlayerPrefs.SetInt("Goku", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(chara == "Indiana"){
			if (PlayerPrefs.GetInt("Indiana") == 1){
				PlayerPrefs.SetString("CH","CH7");
			}
			else{
				if(coin > 1300){
					coin -= 1300;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH7");
					PlayerPrefs.SetInt("Indiana", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(chara == "Malangan"){
			if (PlayerPrefs.GetInt("Malangan") == 1){
				PlayerPrefs.SetString("CH","CH8");
			}
			else{
				if(coin > 1500){
					coin -= 1500;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH8");
					PlayerPrefs.SetInt("Malangan", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(chara == "Darthvader"){
			if (PlayerPrefs.GetInt("Darthvader") == 1){
				PlayerPrefs.SetString("CH","CH9");
			}
			else{
				if(coin > 2000){
					coin -= 2000;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH9");
					PlayerPrefs.SetInt("Darthvader", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(chara == "Paladin"){
			if (PlayerPrefs.GetInt("Paladin") == 1){
				PlayerPrefs.SetString("CH","CH10");
			}
			else{
				if(coin > 2000){
					coin -= 2000;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("CH","CH10");
					PlayerPrefs.SetInt("Paladin", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
	}


	public void buyBackground(string back){
		if(back == "Village"){
			if(coin > 0){
				PlayerPrefs.SetString("BG","BG1");
			}
			else{
				Debug.Log("Coin tidak mencukupi");
			}
		}
		if(back == "Riverside"){
			if (PlayerPrefs.GetInt("Riverside") == 1){
				PlayerPrefs.SetString("BG","BG2");
			}
			else{
				if(coin > 800){
					coin -= 800;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("BG","BG2");
					PlayerPrefs.SetInt("Riverside", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(back == "Beach"){
			if (PlayerPrefs.GetInt("Beach") == 1){
				PlayerPrefs.SetString("BG","BG3");
			}
			else{
				if(coin > 1500){
					coin -= 1500;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("BG","BG3");
					PlayerPrefs.SetInt("Beach", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(back == "Mountain"){
			if (PlayerPrefs.GetInt("Mountain") == 1){
				PlayerPrefs.SetString("BG","BG4");
			}
			else{
				if(coin > 1800){
					coin -= 1800;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("BG","BG4");
					PlayerPrefs.SetInt("Mountain", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(back == "Egypt"){
			if (PlayerPrefs.GetInt("Egypt") == 1){
				PlayerPrefs.SetString("BG","BG5");
			}
			else{
				if(coin > 2200){
					coin -= 2200;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("BG","BG5");
					PlayerPrefs.SetInt("Egypt", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
		if(back == "Desert"){
			if (PlayerPrefs.GetInt("Desert") == 1){
				PlayerPrefs.SetString("BG","BG6");
			}
			else{
				if(coin > 2500){
					coin -= 2500;
					textCoin.text = coin.ToString();
					PlayerPrefs.SetInt("Coin",coin);
					PlayerPrefs.SetString("BG","BG6");
					PlayerPrefs.SetInt("Desert", 1);
				}
				else{
					Debug.Log("Coin tidak mencukupi");
				}
			}
		}
	}


	public void buyTier(){
		if (PlayerPrefs.GetString("Tier") == "Silver"){
			if (coin > 4000){
				coin -= 4000;
				textCoin.text = coin.ToString();
				PlayerPrefs.SetInt("Coin",coin);
				tierAnim.SetTrigger("UP_GOLD");
				PlayerPrefs.SetString("Tier","Gold");
			}
			else{
				Debug.Log("Coin tidak cukup");
			}
		}
		else if (PlayerPrefs.GetString("Tier") == "Gold"){
			if (coin > 5000){
				coin -= 5000;
				textCoin.text = coin.ToString();
				PlayerPrefs.SetInt("Coin",coin);
				tierAnim.SetTrigger("UP_PLATINUM");
				PlayerPrefs.SetString("Tier","Platinum");
			}
			else{
				Debug.Log("Coin tidak cukup");
			}
		}
		else if (PlayerPrefs.GetString("Tier") == "Platinum"){
			if (coin > 8000){
				coin -= 8000;
				textCoin.text = coin.ToString();
				PlayerPrefs.SetInt("Coin",coin);
				tierAnim.SetTrigger("UP_CHAOS");
				PlayerPrefs.SetString("Tier","Chaos");
			}
			else{
				Debug.Log("Coin tidak cukup");
			}
		}
		else{
			if(coin > 2000){
				coin -= 2000;
				textCoin.text = coin.ToString();
				PlayerPrefs.SetInt("Coin",coin);
				tierAnim.SetTrigger("UP_SILVER");
				PlayerPrefs.SetString("Tier","Silver");
			}
			else{
				Debug.Log("Coin tidak cukup");
			}

		}
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
