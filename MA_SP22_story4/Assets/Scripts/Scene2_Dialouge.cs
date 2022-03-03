using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2_Dialouge : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
      //  public Text Char3name;
      //  public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtYogAngry1;
        public GameObject ArtYogAngry2;
        public GameObject ArtYogMonster;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
      //  public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtYogAngry1.SetActive(false);
        ArtYogAngry2.SetActive(false);
        ArtYogMonster.SetActive(false);
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

                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Could you erase the runes? You can’t draw all over the desks.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
         ArtYogAngry1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOG";
                Char2speech.text = "You want me to get rid of my tribute?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Please. It’s against the rules.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOG";
                Char2speech.text = "The Oldest Ones deserve their tribute! You can’t ask me to destroy it!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "I don’t mean to be rude! It’s just that they’re really not the best way to pay tribute!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOG";
                Char2speech.text = "You’re not the best way to be a teacher!";
        }
        else if (primeInt == 8){
                 Char1name.text = "YOU";
                 Char1speech.text = "[Yog has gotten a lot bigger!]";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
        else if (primeInt ==9){
                 Char1name.text = "YOU";
                 Char1speech.text = "[And scarier. I start to cower, just a little bit.]";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==10){
                  Char1name.text = "YOU";
                  Char1speech.text = "Um. I’m sorry.";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt ==11){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "YOG";
                   Char2speech.text = "You better be sorry! My tributes are the best! You need to step back, you’re just some substitute!";
           }
           else if (primeInt ==12){
                    Char1name.text = "YOU";
                    Char1speech.text = "[This is the worst first day I’ve ever had. If you somehow manage to survive this, I'm never subbing for this school again.]";
                    Char2name.text = "";
                    Char2speech.text = "";
          }
         else if (primeInt == 13){
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
                Char1name.text = "YOU";
                Char1speech.text = "Sorry I asked! It’s just that there has to be a better way!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
        }


       else if (primeInt == 200){
                Char1name.text = "YOU";
                Char1speech.text = "It’s just some runes! It can’t be that hard to just use paper!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
        }


        else if (primeInt == 300){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "YOG";
                 Char2speech.text = "AAAAAAARRRGGGGHHH!!!!";
         }
         else if (primeInt == 301){
                  Char1name.text = "YOU";
                  Char1speech.text = "[I’ve screwed up.]";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 302){
                   Char1name.text = "YOU";
                   Char1speech.text = "[Yog’s power starts to come off of him in waves, and I'm clearly the target.]";
                   Char2name.text = "";
                   Char2speech.text = "";
           }
           else if (primeInt == 303){
                    Char1name.text = "YOU";
                    Char1speech.text = "[I have to get behind the desk!]";
                    Char2name.text = "";
                    Char2speech.text = "";
            }
            else if (primeInt == 303){
                     Char1name.text = "YOU";
                     Char1speech.text = "[I have to get behind the desk!]";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
       else if (primeInt == 304){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOG";
                Char2speech.text = "You are pathetic and idiotic, substitute! I will smite you where you stand for disrespecting the Oldest Ones!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOG";
                Char2speech.text = "There is no middle ground! You have insulted me by suggesting I erase them in the first place!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOG";
                Char2speech.text = "DO YOU EVEN VALUE YOUR OWN LIFE, HUMAN?";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene11");
        }
      //  public void SceneChange2(){
            //    SceneManager.LoadScene("Scene2b");
      //  }
}
