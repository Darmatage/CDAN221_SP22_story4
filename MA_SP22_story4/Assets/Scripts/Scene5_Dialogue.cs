using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtDagonSad;
        public GameObject ArtDagonNormal;
        public GameObject ArtDagonMonster;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtDagonNormal.SetActive(false);
        ArtDagonSad.SetActive(false);
        ArtDagonMonster.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //  NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtDagonNormal.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Careful!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtDagonNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "What?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "You’re getting all worked up! You need to calm down.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
         ArtDagonNormal.SetActive(false);
         ArtDagonMonster.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Are you serious? This IS me calm!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "[The sinks rumbling...]";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Like, sorry for having feelings! Sorry for letting the tiniest bit of my emotions show!";
        }
        else if (primeInt ==8){
                 Char1name.text = "YOU";
                 Char1speech.text = "[Oh no, more rumbling.]";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==9){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Dagon";
                  Char2speech.text = "God, I have more emotional intelligence in my left gill than Yog has in his whole body! I don’t see you bothering him?";
          }
       else if (primeInt == 10){
         ArtDagonMonster.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
         ArtDagonSad.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Fine… I can’t get in trouble again this week…";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }


       else if (primeInt == 200){
         ArtDagonSad.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Ugh, maybe you’re right…";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I'm going to have to call Principal Kthulu back in to reprimand you.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "What would Mother Hydra think if she saw this outburst?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene11");
        }
        //public void SceneChange2(){
                //SceneManager.LoadScene("Scene2b");
        }
