using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject ArtYog1;
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
  ArtYog1.SetActive(false);
  ArtBG1.SetActive(true);
  Choice1a.SetActive(false);
  Choice1b.SetActive(false);
  NextScene1Button.SetActive(false);
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
               ArtYog1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Well, maybe I could help you!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtYog1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog-Sothoth";
                Char2speech.text = "What does a human like you know about crafting runes?";
                //gameHandler.AddPlayerStat(1);
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
         ArtYog1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog-Sothoth";
                Char2speech.text = "I doubt you have any knowledge worthy of the Oldest Ones.";
        }
        else if (primeInt == 101){
          ArtYog1.SetActive(true);
                 Char1name.text = "You";
                 Char1speech.text = "Let’s see here…";
                 Char2name.text = "";
                 Char2speech.text = "";
                 primeInt = 299;
         }


       else if (primeInt == 200){
         ArtYog1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog-Sothoth";
                Char2speech.text = "I suppose you’re allowed a brief glance…";
        }
        else if (primeInt == 201){
          ArtYog1.SetActive(true);
                 Char1name.text = "You";
                 Char1speech.text = "Let’s see here…";
                 Char2name.text = "";
                 Char2speech.text = "";
                 primeInt = 299;
         }
         else if (primeInt == 300){
           ArtYog1.SetActive(true);
                  Char1name.text = "You";
                  Char1speech.text = "[Woah. I don’t know what any of these symbols mean… Guess I’ll fake it till I make it.]";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 301){
            ArtYog1.SetActive(true);
                   Char1name.text = "You";
                   Char1speech.text = "Ah, I see here. You’ve forgotten a closed bracket. Don’t worry I just add it in for you here quickly.";
                   Char2name.text = "";
                   Char2speech.text = "";
           }
           else if (primeInt == 302){
             ArtYog1.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Yog-Sothoth";
                    Char2speech.text = "No, stop human! You’re messing up my runes! Now I'll need to start all over.";
            }
            else if (primeInt == 303){
              ArtYog1.SetActive(true);
                     Char1name.text = "You";
                     Char1speech.text = "Well, it’ll give you something productive to do for the rest of detention.";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
             else if (primeInt == 304){
               ArtYog1.SetActive(true);
                      Char1name.text = "You";
                      Char1speech.text = "[Wait… What’s that sound.. Is that coming from the classroom sink?]";
                      Char2name.text = "";
                      Char2speech.text = "";
                      nextButton.SetActive(false);
                      allowSpace = false;
                      NextScene1Button.SetActive(true);
              }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
          ArtYog1.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Hm, not much yet but maybe you could show me?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
          ArtYog1.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "I have a Masters in English! How hard can it be?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene8");
        }
        public void SceneChange2(){
               SceneManager.LoadScene("Scene9");
        }
        public void SceneChange3(){
               SceneManager.LoadScene("Scene10");
        }
    //    public void SceneChange2(){
        //        SceneManager.LoadScene("Scene2b");
        }
