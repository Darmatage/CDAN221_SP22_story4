using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3_Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
      //  public Text Char3name;
      //  public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtYog1;
        public GameObject ArtYog2;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
      //  public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtYog1.SetActive(false);
        ArtYog2.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
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
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Hey, there. You’re Yog-Sothoth, right?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
         ArtYog1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog";
                Char2speech.text = "...?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         ArtYog1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
         ArtYog1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "What are you doing? Practicing for art class?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         ArtYog1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog";
                Char2speech.text = "...";
        }
       else if (primeInt ==7){
         ArtYog1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "[take a closer look?]";
                Char2name.text = "";
                Char2speech.text = "";
                Choice1a.SetActive(true); // function Choice1aFunct()
                NextScene1Button.SetActive(true);
                nextButton.SetActive(false);
        }
        else if (primeInt == 8){
          ArtYog1.SetActive(true);
          ArtBG1.SetActive(false);
          ArtBG2.SetActive(true);
                 Char1name.text = "YOU";
                 Char1speech.text = "[Oh boy, it's runes.]";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Choice1a.SetActive(false); // function Choice1aFunct()
                 NextScene1Button.SetActive(false);
                 nextButton.SetActive(true);
         }
        else if (primeInt ==9){
          ArtYog1.SetActive(true);
                 Char1name.text = "YOU";
                 Char1speech.text = "So what are you going to do with those? What do they do?";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==10){
           ArtYog2.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Yog";
                  Char2speech.text = "They’re tribute to the Oldest Ones.";
          }
          else if (primeInt ==11){
            ArtYog2.SetActive(true);
                   Char1name.text = "YOU";
                   Char1speech.text = "The Oldest Ones?";
                   Char2name.text = "";
                   Char2speech.text = "";
           }
           else if (primeInt ==12){
             ArtYog1.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Yog";
                    Char2speech.text = "The seniors.";
          }
          else if (primeInt ==13){
            ArtYog1.SetActive(true);
                   Char1name.text = "YOU";
                   Char1speech.text = "The seniors? You’re drawing on the desk for the upperclassmen? Why? [It doesn’t seem like he wants to tell you, so you wait.] ";
                   Char2name.text = "";
                   Char2speech.text = "";
         }
         else if (primeInt ==14){
           ArtYog1.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Yog";
                  Char2speech.text = "They've been here the longest. I wish to pay tribute.";
        }
        else if (primeInt ==15){
          ArtYog1.SetActive(true);
                 Char1name.text = "YOU";
                 Char1speech.text = "[This is weird. They’re just upperclassmen. Your upperclassmen weren’t paid tribute— unless they played football, you guess.]";
                 Char2name.text = "";
                 Char2speech.text = "";
       }
       else if (primeInt ==16){
         ArtYog1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "[Also, this really shouldn’t be on a desk. Was Yog-Sothoth drawing on all of his desks for the seniors or something?]";
                Char2name.text = "";
                Char2speech.text = "";
      }
      else if (primeInt ==17){
        ArtYog1.SetActive(true);
               Char1name.text = "YOU";
               Char1speech.text = "So, did you end up in detention because of this?";
               Char2name.text = "";
               Char2speech.text = "";
     }
     else if (primeInt ==18){
       ArtYog2.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Yog";
              Char2speech.text = "...Maybe.";
    }
    else if (primeInt ==19){
      ArtYog1.SetActive(true);
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Yog";
             Char2speech.text = "I just want the Oldest Ones, the Masters of this school, to understand how great and all powerful they are!";
   }
   else if (primeInt ==20){
     ArtYog2.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Well…";
            Char2name.text = "";
            Char2speech.text = "";
  }
  else if (primeInt ==21){

           Char1name.text = "YOU";
           Char1speech.text = "Something must be done...";
           Char2name.text = "";
           Char2speech.text = "";
           NextScene2Button.SetActive(true);
           NextScene3Button.SetActive(true);
           nextButton.SetActive(false);
 }

// ENCOUNTER AFTER CHOICE #1

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
               SceneManager.LoadScene("Scene1");
        }
        public void SceneChange2(){
               SceneManager.LoadScene("Scene9");
        }
        public void SceneChange3(){
               SceneManager.LoadScene("Scene10");
        }
      //  public void SceneChange2(){
            //    SceneManager.LoadScene("Scene2b");
      //  }
}
