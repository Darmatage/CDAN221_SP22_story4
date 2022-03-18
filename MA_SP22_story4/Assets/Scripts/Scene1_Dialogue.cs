using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1_Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
        public Text Char5name;
        public Text Char5speech;

        //public Text Char3name;
        //public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtKthulu1;
        public GameObject ArtKthulu2;
        public GameObject ArtDagon1;
        public GameObject ArtYog1;
        public GameObject ArtNar1;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtKthulu1.SetActive(false);
        ArtKthulu2.SetActive(false);
        ArtDagon1.SetActive(false);
        ArtYog1.SetActive(false);
        ArtNar1.SetActive(false);
        ArtBG1.SetActive(true);
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
               ArtKthulu1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "[Today, you have been asked to sub in as a detention teacher at Lovecraft High.]";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
               ArtKthulu1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "[It’s your first time substituting at this school, but it is in the district you usually go around in, so it's not too surprising that the school would ask you to do this. Though…]";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 4){
               ArtKthulu1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "[This school is for monsters of the unfathomable kind. You like the stories, but you aren't sure if you’re ready to meet the real deal.]";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 5){
               ArtKthulu1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Hello. I’m here to sub in for detention?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==6){
              ArtKthulu1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Principal Kthulu";
                Char2speech.text = "Huh.";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7){
               ArtKthulu1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Is there a problem?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt ==8){
              ArtKthulu1.SetActive(false);
               ArtKthulu2.SetActive(true);
                 dialogue.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Principal Kthulu";
                 Char2speech.text = "You have less eyes than I was expecting.";
                 //gameHandler.AddPlayerStat(1);
         }
         else if (primeInt == 9){
                ArtKthulu1.SetActive(true);
                ArtKthulu2.SetActive(false);
                 dialogue.SetActive(true);
                 Char1name.text = "YOU";
                 Char1speech.text = "[Principal Kthulu looks you up and down. You kind of regret dressing business casual instead of full business.]";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==10){
                ArtKthulu1.SetActive(true);
                  dialogue.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Principal Kthulu";
                  Char2speech.text = "I suppose it's no matter, you're just covering detention.";
                  //gameHandler.AddPlayerStat(1);
          }
          else if (primeInt ==11){
                 ArtKthulu1.SetActive(true);
                   dialogue.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Principal Kthulu";
                   Char2speech.text = "We have three students staying for detention today. Daegon, Yog-Sothoth, and Nyarlathotep.";
                   //gameHandler.AddPlayerStat(1);
           }
           else if (primeInt ==12){
                  ArtKthulu1.SetActive(true);
                    dialogue.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Principal Kthulu";
                    Char2speech.text = "I trust you’ll do alright with them?";
                    //gameHandler.AddPlayerStat(1);
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
            ArtKthulu1.SetActive(true);
            ArtKthulu2.SetActive(false);
              dialogue.SetActive(true);
                Char1name.text = "Kthulu";
                Char1speech.text = "I’ll leave you be now, call if anything goes awry.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
            ArtKthulu1.SetActive(false);
              dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "[You look at your three students.]";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }

        else if (primeInt == 102){
            ArtDagon1.SetActive(true);
             ArtKthulu1.SetActive(false);
               dialogue.SetActive(true);
                 Char1name.text = "YOU";
                 Char1speech.text = "[There’s some sort of… fish monster fiddling with the sink in the back, shaking it kind of like the sink is a vending machine with the chip bag stuck.]";
                 Char2name.text = "";
                 Char2speech.text = "";
                 nextButton.SetActive(true);
                 allowSpace = false;
                 NextScene1Button.SetActive(false);
         }

       else if (primeInt == 104){
         ArtDagon1.SetActive(true);
           dialogue.SetActive(true);
             Char3name.text = "Dagon";
             Char3speech.text = "grumble…grumble…c’mon you stupid sink… grumble…";
             Char2name.text = "";
             Char2speech.text = "";
             nextButton.SetActive(true);
             allowSpace = false;
             NextScene1Button.SetActive(false);

          }
        else if (primeInt == 105){
          ArtDagon1.SetActive(false);
             ArtYog1.SetActive(true);
             dialogue.SetActive(true);
             Char1name.text = "YOU";
             Char1speech.text = "[There’s also a monster sitting at a desk hunched over. Most of what’s going on is covered up by tentacles, but you don’t think there’s a piece of paper between that pen and the desk.]";
             Char2name.text = "";
             Char2speech.text = "";
             nextButton.SetActive(true);
             allowSpace = false;
             NextScene1Button.SetActive(false);
          }
      else if (primeInt == 106){
        ArtYog1.SetActive(true);
          dialogue.SetActive(true);
            Char4name.text = "Yog";
            Char4speech.text = "I have to make sure the tribute is perfect… yes, that’s good.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(true);
            allowSpace = false;
            NextScene1Button.SetActive(false);
          }

      else if (primeInt == 107){
        ArtYog1.SetActive(false);
          ArtNar1.SetActive(true);

          dialogue.SetActive(true);
          Char1name.text = "YOU";
          Char1speech.text = "[Finally, there’s a monster with a kind of cool vibe and a kind of… wild looking head, setting up a phone and clearing desks and chairs away from an area.]";
          Char2name.text = "";
          Char2speech.text = "";
          nextButton.SetActive(true);
          allowSpace = false;
          NextScene1Button.SetActive(false);
          }

       else if (primeInt == 108){
         ArtNar1.SetActive(true);
           dialogue.SetActive(true);
             Char1name.text = "YOU";
             Char1speech.text = "[Finally, there’s a monster with a kind of cool vibe and a kind of… wild looking head, setting up a phone and clearing desks and chairs away from an area.]";
             Char2name.text = "";
             Char2speech.text = "";
             nextButton.SetActive(true);
             allowSpace = false;
             NextScene1Button.SetActive(false);
           }

           else if (primeInt == 109){
             ArtNar1.SetActive(true);
               dialogue.SetActive(true);
                 Char5name.text = "Nyarlathotep";
                 Char5speech.text = "The viewers are gonna love this one. I’ve even got the chalk!";
                 Char2name.text = "";
                 Char2speech.text = "";
                 nextButton.SetActive(true);
                 allowSpace = false;
                 NextScene1Button.SetActive(false);
            }

            else if (primeInt == 110){
              ArtNar1.SetActive(false);
                  dialogue.SetActive(true);
                    Char1name.text = "YOU";
                    Char1speech.text = "[They all seem like troublemakers. You’ve got to figure out what’s going on.]";
                    Char2name.text = "";
                    Char2speech.text = "";
                    nextButton.SetActive(true);
                    allowSpace = false;
                    NextScene1Button.SetActive(false);
              }

              else if (primeInt == 111){
                 ArtNar1.SetActive(false);
                    dialogue.SetActive(true);
                      Char1name.text = "YOU";
                      Char1speech.text = "WHO DO YOU APPROACH FIRST";
                      Char2name.text = "";
                      Char2speech.text = "";
                      nextButton.SetActive(false);
                      allowSpace = false;
                      NextScene1Button.SetActive(true);
                      NextScene2Button.SetActive(true);
                      NextScene3Button.SetActive(true);
  }
}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
          ArtKthulu1.SetActive(false);
          ArtKthulu2.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kthulu";
                Char2speech.text = "Excellent.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
              ArtKthulu1.SetActive(false);
              ArtKthulu2.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kthulu";
                Char2speech.text = "This isn't like your human detentions.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene4");
}}
