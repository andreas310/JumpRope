using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour {

	public GameObject getKarakter;
	public GameObject getPause;
	public GameObject LoadingScreen;
	public Slider getSlideMusic;
	public Slider getSlideVolume;
	public Slider sliderLoading;
	public Text textProgress;
	public AudioSource sourceAudio;
	public Image getBackground;
	public Image getTier;
	public TextMeshProUGUI textCoin;
	public Animator anim;
	public Sprite bgRiverside;
	public Sprite bgBeach;
	public Sprite bgMountain;
	public Sprite bgEgypt;
	public Sprite bgDesert;
	public Sprite bronze;
	public Sprite silver;
	public Sprite gold;
	public Sprite platinum;
	public Sprite chaos;
	int plus;
	string jump;
	string karakterselect;
	string bgselect;
	int plusTier;
	float times;
	//drag
	Vector2 firstPressPos;
    Vector2 currentSwipe;

 

	// Use this for initialization
	void Start () {

		//set Tier
		if(PlayerPrefs.GetString("Tier") == "Silver"){
			getTier.sprite = silver;
			plusTier = 5;
		}
		else if(PlayerPrefs.GetString("Tier") == "Gold"){
			getTier.sprite = gold;
			plusTier = 6;
		}
		else if(PlayerPrefs.GetString("Tier") == "Platinum"){
			getTier.sprite = platinum;
			plusTier = 7;
		}
		else if(PlayerPrefs.GetString("Tier") == "Chaos"){
			getTier.sprite = chaos;
			plusTier = 8;
		}
		else{
			PlayerPrefs.SetString("Tier", "Bronze");
			getTier.sprite = bronze;
			plusTier = 4;

		}

		plus = PlayerPrefs.GetInt("Coin");
		textCoin.text = plus.ToString();
		jump = null;
		karakterselect = PlayerPrefs.GetString("CH");
		bgselect = PlayerPrefs.GetString("BG");

		//music
		getSlideVolume.value = PlayerPrefs.GetFloat("Volume");
		if (PlayerPrefs.GetInt("Music") == 1){
			sourceAudio.Play();
			getSlideMusic.value = 1;
		}
		if (PlayerPrefs.GetInt("Music") == 0){
			sourceAudio.Play();
			getSlideMusic.value = 1;
			getSlideVolume.value = 1;

		}
		if (PlayerPrefs.GetInt("Music") == 2){
			sourceAudio.Pause();
			getSlideMusic.value = 0;

		}


	}
	
	// Update is called once per frame
	void Update () {
		//QUIT
		if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }

		//klik + drag
		if (Input.GetMouseButtonDown (0)) {
             firstPressPos = Input.mousePosition;
         }
         if (Input.GetMouseButtonUp (0)) {
             currentSwipe = (Vector2)Input.mousePosition - firstPressPos;
             if(currentSwipe.y > 150){
             	Debug.Log("Swipe Up");
             	if(karakterselect == "CH2"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH2_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH2_JUMP3";
					}
				}
				else if(karakterselect == "CH3"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH3_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH3_JUMP3";
					}
				}
				else if(karakterselect == "CH4"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH4_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH4_JUMP3";
					}
				}
				else if(karakterselect == "CH5"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH5_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH5_JUMP3";
					}
				}
				else if(karakterselect == "CH6"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH6_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH6_JUMP3";
					}
				}
				else if(karakterselect == "CH7"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH7_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH7_JUMP3";
					}
				}
				else if(karakterselect == "CH8"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH8_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH8_JUMP3";
					}
				}
				else if(karakterselect == "CH9"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH9_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH9_JUMP3";
					}
				}
				else if(karakterselect == "CH10"){
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH10_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH10_JUMP3";
					}
				}
				else{
					if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH1_JUMP3";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH1_JUMP3";
					}
					else{
						Debug.Log("Tier tidak mencukupi");
					}
				}
             }
             else if(currentSwipe.y < -150){
             	Debug.Log("Swipe Down");
             	if(karakterselect == "CH2"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH2_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH2_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH2_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH2_JUMP2";
					}
				}
				else if(karakterselect == "CH3"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH3_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH3_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH3_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH3_JUMP2";
					}
				}
				else if(karakterselect == "CH4"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH4_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH4_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH4_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH4_JUMP2";
					}
				}
				else if(karakterselect == "CH5"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH5_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH5_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH5_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH5_JUMP2";
					}
				}
				else if(karakterselect == "CH6"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH6_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH6_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH6_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH6_JUMP2";
					}
				}
				else if(karakterselect == "CH7"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH7_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH7_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH7_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH7_JUMP2";
					}
				}
				else if(karakterselect == "CH8"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH8_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH8_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH8_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH8_JUMP2";
					}
				}
				else if(karakterselect == "CH9"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH9_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH9_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH9_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH9_JUMP2";
					}
				}
				else if(karakterselect == "CH10"){
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH10_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH10_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH10_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH10_JUMP2";
					}
				}
				else{
					if(PlayerPrefs.GetString("Tier") == "Silver"){
						jump = "CH1_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Gold"){
						jump = "CH1_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Platinum"){
						jump = "CH1_JUMP2";
					}
					else if(PlayerPrefs.GetString("Tier") == "Chaos"){
						jump = "CH1_JUMP2";
					}
					else{
						Debug.Log("Tier tidak mencukupi");
					}
				}
             }
             else{
             	Debug.Log("Tap");
             	if(karakterselect == "CH2"){
					jump = "CH2_JUMP1";
				}
				else if(karakterselect == "CH3"){
					jump = "CH3_JUMP1";
				}
				else if(karakterselect == "CH4"){
					jump = "CH4_JUMP1";
				}
				else if(karakterselect == "CH5"){
					jump = "CH5_JUMP1";
				}
				else if(karakterselect == "CH6"){
					jump = "CH6_JUMP1";
				}
				else if(karakterselect == "CH7"){
					jump = "CH7_JUMP1";
				}
				else if(karakterselect == "CH8"){
					jump = "CH8_JUMP1";
				}
				else if(karakterselect == "CH9"){
					jump = "CH9_JUMP1";
				}
				else if(karakterselect == "CH10"){
					jump = "CH10_JUMP1";
				}
				else{
					jump = "CH1_JUMP1";
				}
             }
         }
			

		//load background
		if (bgselect == "BG2"){
			getBackground.sprite = bgRiverside;
		}
		if (bgselect == "BG3"){
			getBackground.sprite = bgBeach;
		}
		if (bgselect == "BG4"){
			getBackground.sprite = bgMountain;
		}
		if (bgselect == "BG5"){
			getBackground.sprite = bgEgypt;
		}
		if (bgselect == "BG6"){
			getBackground.sprite = bgDesert;
		}
		

		//animasi + jump karakter + coin
		//KARAKTER NATSUKI
		if (karakterselect == "CH2"){
			if (jump == "CH2_JUMP1"){
        		anim.SetTrigger("CH2_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH2_JUMP2"){
        		anim.SetTrigger("CH2_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH2_JUMP3"){
        		anim.SetTrigger("CH2_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH2_STAND");
			}
        }

        //KARAKTER WIZARD
		else if (karakterselect == "CH3"){
			if (jump == "CH3_JUMP1"){
        		anim.SetTrigger("CH3_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH3_JUMP2"){
        		anim.SetTrigger("CH3_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH3_JUMP3"){
        		anim.SetTrigger("CH3_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH3_STAND");
			}
        }

        //KARAKTER PANDA
		else if (karakterselect == "CH4"){
			if (jump == "CH4_JUMP1"){
        		anim.SetTrigger("CH4_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH4_JUMP2"){
        		anim.SetTrigger("CH4_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH4_JUMP3"){
        		anim.SetTrigger("CH4_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH4_STAND");
			}
        }

        //KARAKTER ZELDA
		else if (karakterselect == "CH5"){
			if (jump == "CH5_JUMP1"){
        		anim.SetTrigger("CH5_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH5_JUMP2"){
        		anim.SetTrigger("CH5_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH5_JUMP3"){
        		anim.SetTrigger("CH5_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH5_STAND");
			}
        }

         //KARAKTER DRAGONBALL
		else if (karakterselect == "CH6"){
			if (jump == "CH6_JUMP1"){
        		anim.SetTrigger("CH6_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH6_JUMP2"){
        		anim.SetTrigger("CH6_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH6_JUMP3"){
        		anim.SetTrigger("CH6_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH6_STAND");
			}
        }

        //KARAKTER INDIANA
		else if (karakterselect == "CH7"){
			if (jump == "CH7_JUMP1"){
        		anim.SetTrigger("CH7_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH7_JUMP2"){
        		anim.SetTrigger("CH7_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH7_JUMP3"){
        		anim.SetTrigger("CH7_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH7_STAND");
			}
        }

         //KARAKTER MALANGAN
		else if (karakterselect == "CH8"){
			if (jump == "CH8_JUMP1"){
        		anim.SetTrigger("CH8_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH8_JUMP2"){
        		anim.SetTrigger("CH8_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH8_JUMP3"){
        		anim.SetTrigger("CH8_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH8_STAND");
			}
        }

         //KARAKTER STARWARS
		else if (karakterselect == "CH9"){
			if (jump == "CH9_JUMP1"){
        		anim.SetTrigger("CH9_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH9_JUMP2"){
        		anim.SetTrigger("CH9_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH9_JUMP3"){
        		anim.SetTrigger("CH9_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH9_STAND");
			}
        }

         //KARAKTER PALADIN
		else if (karakterselect == "CH10"){
			if (jump == "CH10_JUMP1"){
        		anim.SetTrigger("CH10_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH10_JUMP2"){
        		anim.SetTrigger("CH10_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH10_JUMP3"){
        		anim.SetTrigger("CH10_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH10_STAND");
			}
        }

        //KARAKTER TOMMY
        else{
        	if (jump == "CH1_JUMP1"){
        		anim.SetTrigger("CH1_JUMP1");
				times += Time.deltaTime;	
				if(times>0.5){
					plus = plus + plusTier;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH1_JUMP2"){
        		anim.SetTrigger("CH1_JUMP2");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 2;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == "CH1_JUMP3"){
        		anim.SetTrigger("CH1_JUMP3");
				times += Time.deltaTime;	
				if(times>0.58){
					plus = plus + plusTier + 3;
					PlayerPrefs.SetInt("Coin",plus);
					textCoin.text = plus.ToString();
					times = 0;
					jump = null;
				}
			}
			else if (jump == null){
				anim.SetTrigger("CH1_STAND");
			}
        }
	}

	public void PausePress(){
		getKarakter.SetActive(false);
		getPause.SetActive(true);
		Time.timeScale = 0f;
	}

	public void ResumePress(){
		getKarakter.SetActive(true);
		getPause.SetActive(false);
		Time.timeScale = 1f;
	}

	public void MusicStatus(float slid){
		if (slid == 0){
			sourceAudio.Pause();
			PlayerPrefs.SetInt("Music", 2);
		}
		if (slid == 1){
			sourceAudio.Play();
			PlayerPrefs.SetInt("Music", 1);
		}
	}

	public void VolumeMaster(float volume){
		sourceAudio.volume = volume;
		PlayerPrefs.SetFloat("Volume", volume);
	}

	public void LoadScene(int sceneIndex){
		StartCoroutine(LoadAsynchronously(sceneIndex));
	}

	IEnumerator LoadAsynchronously(int sceneIndex){
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

		LoadingScreen.SetActive(true);
		getKarakter.SetActive(false);

		while (!operation.isDone){
			float progress = Mathf.Clamp01(operation.progress / .9f);
			sliderLoading.value = progress;
			textProgress.text = progress * 100f + "%";

			yield return null;
		}
	}

	//INI CHEAT NYA KAKA..=================================================================
	public void MaxTier(){
		PlayerPrefs.SetString("Tier", "Chaos");
		Application.LoadLevel("GamePlay1");
	}
	public void ResetTier(){
		PlayerPrefs.SetString("Tier", "Bronze");
		PlayerPrefs.SetString("CH","CH1");
		PlayerPrefs.SetString("BG","BG1");
		PlayerPrefs.SetInt("Natsuki", 0);
		PlayerPrefs.SetInt("Wizard", 0);
		PlayerPrefs.SetInt("Panda", 0);
		PlayerPrefs.SetInt("Zelda", 0);
		PlayerPrefs.SetInt("Goku", 0);
		PlayerPrefs.SetInt("Indiana", 0);
		PlayerPrefs.SetInt("Malangan", 0);
		PlayerPrefs.SetInt("Darthvader", 0);
		PlayerPrefs.SetInt("Paladin", 0);
		PlayerPrefs.SetInt("Riverside", 0);
		PlayerPrefs.SetInt("Beach", 0);
		PlayerPrefs.SetInt("Mountain", 0);
		PlayerPrefs.SetInt("Egypt", 0);
		PlayerPrefs.SetInt("Desert", 0);
		Application.LoadLevel("GamePlay1");
	}
	public void Milyader(){
		PlayerPrefs.SetInt("Coin", 90000);
		Application.LoadLevel("GamePlay1");
	}
	public void Miskin(){
		PlayerPrefs.SetInt("Coin", 0);
		Application.LoadLevel("GamePlay1");
	}
	//=====================================================================================

}
