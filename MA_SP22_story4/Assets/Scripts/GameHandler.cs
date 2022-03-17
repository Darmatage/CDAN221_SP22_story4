using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour{

        public static int playerStat;
        //public GameObject textGameObject;
        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;

void Awake (){
        SetLevel (volumeLevel);
        GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
        if (sliderTemp != null){
                sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                sliderVolumeCtrl.value = volumeLevel;
        }
}

void Start (){
        pauseMenuUI.SetActive(false);
        GameisPaused = false;
}

void Update (){
        if (Input.GetKeyDown(KeyCode.Escape)){
                if (GameisPaused){
                        Resume();
                }
                else{
                        Pause();
                }
        }
}
        //void Start () { UpdateScore (); }

        public void UpdatePlayerStat(int amount){
                playerStat += amount;
                Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }


        public int CheckPlayerStat(){
                return playerStat;
        }

        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void Credits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}
