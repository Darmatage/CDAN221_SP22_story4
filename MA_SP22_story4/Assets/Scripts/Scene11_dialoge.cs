using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene11_dialoge : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtNar1;
        public GameObject ArtNar2;
        public GameObject ArtNar3;
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
        ArtNar1.SetActive(false);
        ArtNar2.SetActive(false);
        ArtNar3.SetActive(false);
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
                Char1speech.text = "[In the middle of talking to the student in front of me, Nyarlathotep gets louder. Was I talking to the wrong student?]";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
         ArtNar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NAR";
                Char2speech.text = "What’s up YouCraft? Have I got the prank for you!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Oh no. Wait!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "BOOOOOOM!!!!!!!!!!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "[Oh no, oh yikes, there’s smoke all over!]";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "[I have to get over there!]";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 8){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "NAR";
                 Char2speech.text = "Oh, hey teach. I can’t believe Kthulu hired a human. Imagine my luck!";
         }
        else if (primeInt ==9){
                 Char1name.text = "YOU";
                 Char1speech.text = "What’s going on?";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt ==10){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "NAR";
                  Char2speech.text = " It’s just a little summoning circle. I’m ordering some food for later, and filming it for my YouCraft channel.";
          }
          else if (primeInt ==11){
                   Char1name.text = "YOU";
                   Char1speech.text = "Food?";
                   Char2name.text = "";
                   Char2speech.text = "";
           }
           else if (primeInt ==12){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "NAR";
                    Char2speech.text = "Like, fast food, yeah.";
          }
          else if (primeInt ==13){
                   Char1name.text = "YOU";
                   Char1speech.text = "This couldn’t have waited? What’s wrong with you?!";
                   Char2name.text = "";
                   Char2speech.text = "";
         }
         else if (primeInt ==14){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "NAR";
                  Char2speech.text = "...";
        }
        else if (primeInt ==15){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "NAR";
                 Char2speech.text = "You know, I'd bet that the delivery demon would love a human snack for a tip...";
       }
       else if (primeInt ==16){
                Char1name.text = "YOU";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
      }
       else if (primeInt ==17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NAR";
                Char2speech.text = "Oh yeah. Hey, Daegon, Yog-Sothoth, help me sacrifice this human!";
      }
         else if (primeInt == 18){
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
                 Char1name.text = "YOU";
                 Char1speech.text = "[Yog and Da come over to see what’s going on. They both seem way to down with pushing me into the portal.]";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 301){
                  ArtNar1.SetActive(true);
                  ArtNar2.SetActive(true);
                  Char1name.text = "DA";
                  Char1speech.text = "Hey, did you order enough for everyone?";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 302){
            ArtNar1.SetActive(true);
            ArtNar2.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "NAR";
                   Char2speech.text = "What do you take for for? A jerk? Everyone's eating today.";
           }
           else if (primeInt == 303){
                    ArtNar1.SetActive(true);
                    ArtNar3.SetActive(true);
                    Char1name.text = "YOG";
                    Char1speech.text = "[As soon as this human;s in the portal, I'm going right back to drawing for the Oldest Ones.]";
                    Char2name.text = "";
                    Char2speech.text = "";
            }
            else if (primeInt == 304){
              ArtNar1.SetActive(true);
              ArtNar2.SetActive(true);
              ArtNar3.SetActive(true);
                     Char1name.text = "YOU";
                     Char1speech.text = "This sucks.";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
             else if (primeInt == 305){
                      Char1name.text = "YOU";
                      Char1speech.text = "[Something I can't even comprehend crawls out of the portal holding a paper bag that smells pretty good.]";
                      Char2name.text = "";
                      Char2speech.text = "";
              }
              else if (primeInt == 306){
                       Char1name.text = "YOU";
                       Char1speech.text = "[Nar dishes out the necessary cash, and then the students push me in.]";
                       Char2name.text = "";
                       Char2speech.text = "";
                }
       else if (primeInt == 307){
                Char1name.text = "YOU";
                Char1speech.text = "[Worst substitute job ever.]";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NAR";
                Char2speech.text = "Well, I’ll guess you’ll have to clear your schedule.";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NAR";
                Char2speech.text = "Wow, that was easy.";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene15");
        }
      //  public void SceneChange2(){
            //    SceneManager.LoadScene("Scene2b");
      //  }
}
