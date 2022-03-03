using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6_Dialogue : MonoBehaviour {
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
                Char1speech.text = "Wow, that’s quite the power you have! Mother Hydra must be very proud.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtDagonNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Like, yeah, I think she is…";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         ArtDagonNormal.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "A gifted student like you? I’m certain!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
         ArtDagonNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Yeah, I don’t know… ";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         ArtDagonNormal.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "You don't think?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
         ArtDagonNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Well, my mentors think I need to do more to prove myself. But that’s just, like, so much work for me right now.";
        }
        else if (primeInt ==8){
          ArtDagonNormal.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "I bet there are lots of small ways to prove yourself though! I can think of all kinds of ways you could apply yourself in the classroom to show that.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==9){
           ArtDagonNormal.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Dagon";
                  Char2speech.text = "Hm.. Maybe you’re right…";
          }
          else if (primeInt ==10){
            ArtDagonNormal.SetActive(false);
                   Char1name.text = "YOU";
                   Char1speech.text = "I’m sure they’ll see how your strength academically could carry over to your strength, uh, aquatically.";
                   Char2name.text = "";
                   Char2speech.text = "";
           }
           else if (primeInt ==11){
             ArtDagonNormal.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Dagon";
                    Char2speech.text = "My strength… Yeah, my strength.";
            }
            else if (primeInt ==12){
              ArtDagonNormal.SetActive(false);
                     Char1name.text = "YOU";
                     Char1speech.text = "[The sink is rumbling again...]";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
       else if (primeInt == 13){
         ArtDagonNormal.SetActive(false);
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
          ArtDagonNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Yeah, no. I have a better idea of how to prove myself.";
                nextButton.SetActive(false);
}
       else if (primeInt == 101){
         ArtDagonNormal.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Wait, no that’s not what I meant-";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }


       else if (primeInt == 200){
         ArtDagonNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "AAAAGGHGGGhhhhH!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "So, maybe we could just sit back down at our desk and get started on our homework. Wouldn’t that be fun?";
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
                Char1speech.text = "Dagon, calm down right this instant-";
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
        //public void SceneChange2(){
                //SceneManager.LoadScene("Scene2b");
        }
