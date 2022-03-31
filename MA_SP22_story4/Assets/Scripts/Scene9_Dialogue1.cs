using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9_Dialogue1 : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
      //  public Text Char3name;
      //  public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtYog1;
        //public GameObject ArtYog2;
        public GameObject ArtBG1;
        //public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        //public GameObject NextScene3Button;
      //  public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtYog1.SetActive(false);
        //ArtYog2.SetActive(false);
        ArtBG1.SetActive(true);
        //ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        //NextScene3Button.SetActive(false);
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
          NextScene1Button.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Well, maybe I could help you!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
        }
       else if (primeInt ==3){
         NextScene1Button.SetActive(false);
         ArtYog1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog";
                Char2speech.text = "What does a human like you know about crafting runes?";
                nextButton.SetActive(true);
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         NextScene1Button.SetActive(false);
         ArtYog1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true);
                nextButton.SetActive(false);
        }
       else if (primeInt == 5){
         ArtYog1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                Choice1a.SetActive(false); // function Choice1aFunct()
                Choice1b.SetActive(false);
                NextScene1Button.SetActive(false);
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         NextScene1Button.SetActive(false);
         ArtYog1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog";
                Char2speech.text = "...I doubt you have any knowledge of the Oldest Ones.";
                nextButton.SetActive(true);
        }
       else if (primeInt ==7){
         NextScene1Button.SetActive(false);
         ArtYog1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Let's see here...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
        }
        else if (primeInt == 8){
          NextScene1Button.SetActive(false);
          ArtYog1.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Yog";
                 Char2speech.text = "I suppose you're allowed a brief glance.";
                 nextButton.SetActive(true);
         }
        else if (primeInt ==9){
          NextScene1Button.SetActive(false);
          ArtYog1.SetActive(true);
                 Char1name.text = "YOU";
                 Char1speech.text = "[Woah. I don’t know what any of these symbols mean… Guess I’ll fake it till I make it.]";
                 Char2name.text = "";
                 Char2speech.text = "";
                 nextButton.SetActive(true);
         }
         else if (primeInt ==10){
           NextScene1Button.SetActive(false);
           ArtYog1.SetActive(true);
                  Char1name.text = "YOU";
                  Char1speech.text = "Ah, I see here. You’ve forgotten a closed bracket. Don’t worry I just add it in for you here quickly.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  nextButton.SetActive(true);
          }
          else if (primeInt ==11){
            NextScene1Button.SetActive(false);
            ArtYog1.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Yog";
                   Char2speech.text = "No- Stop human! You're messing up my runes! I can't afford to start all over because of your ineptitude!";
                   nextButton.SetActive(true);
           }
           else if (primeInt ==12){
             NextScene1Button.SetActive(false);
             ArtYog1.SetActive(true);
                    Char1name.text = "YOU";
                    Char1speech.text = "[Yikes.] Well, it’ll give you something productive to do for the rest of detention.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(true);
          }
          else if (primeInt ==13){
            ArtYog1.SetActive(true);
                   Char1name.text = "YOU";
                   Char1speech.text = "[Wait… What’s that sound.. Is that coming from the classroom sink?]";
                   Char2name.text = "";
                   Char2speech.text = "";
                  NextScene1Button.SetActive(true);
                  nextButton.SetActive(false);
         }

// ENCOUNTER AFTER CHOICE #1

     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)


        public void SceneChange1(){
               SceneManager.LoadScene("Scene8");
        }
      //  public void SceneChange2(){
            //    SceneManager.LoadScene("Scene2b");
      //  }
}
