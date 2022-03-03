using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene12_Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
      //  public Text Char3name;
      //  public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtNar1;
        public GameObject ArtNar2;
        public GameObject ArtKthulu;
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
        ArtKthulu.SetActive(false);
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
                Char1speech.text = "[Principal Kthulu is here to help! Finally!]";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
         ArtKthulu.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "KTHULU";
                Char2speech.text = "What's the issue here?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtNar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NAR";
                Char2speech.text = "The human’s trying to stop me from doing a summon.";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = " He’s refusing to stop! It’s putting everyone in danger, summoning a demon for some food!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NAR";
                Char2speech.text = "You’re not used to this school at all, wow.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "KTHULU";
                Char2speech.text = "Nyarlathotep is right. You don’t understand our school";
        }
        else if (primeInt == 8){
                 Char1name.text = "YOU";
                 Char1speech.text = "What?";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
        else if (primeInt ==9){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "KTHULU";
                 Char2speech.text = "You dare interrupt a summoning at any time? These students are far and away better than any old human who enters this building.";
         }
         else if (primeInt ==10){
                  Char1name.text = "YOU";
                  Char1speech.text = "Then why not explain that in the first place instead of just saying that you won’t stop?";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt ==11){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "NAR";
                   Char2speech.text = "That's easy.";
           }
           else if (primeInt ==12){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "NAR";
                    Char2speech.text = "You're just some human.";
          }
          else if (primeInt ==13){
                   Char1name.text = "YOU";
                   Char1speech.text = "[This is the worst school I’ve ever substituted at. I'm never ever coming back.]";
                   Char2name.text = "";
                   Char2speech.text = "";
           }
           else if (primeInt ==14){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "KTHULU";
                    Char2speech.text = "Nyarlethotep, begin your summon.";
            }
            else if (primeInt ==15){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "KTHULU";
                     Char2speech.text = "We have a sacrifice to make.";
             }
           else if (primeInt ==16){
                    Char1name.text = "YOU";
                    Char1speech.text = "Huh?";
                    Char2name.text = "";
                    Char2speech.text = "";
          }
             else if (primeInt ==17){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "KTHULU";
                      Char2speech.text = "You're being sacrificed, human.";
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
        else if (primeInt ==100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NAR";
                Char2speech.text = "Anyway, let me grab my camera. It's vital to the summon.";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "KTHULU";
                Char2speech.text = "I doubt that. Besides, we don't need another video of a human getting devoured by a delivery demon on the internet.";
                primeInt = 299;
        }

        else if (primeInt ==200){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "NAR";
                 Char2speech.text = "Can I film this go down?";
         }
         else if (primeInt ==201){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "KTHULU";
                  Char2speech.text = "I don't see why not. Humiliation sometimes aids in a lesson.";
          }
       else if (primeInt == 202){
                Char1name.text = "YOU";
                Char1speech.text = "It's literally a Monday! You don't need to do this!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
        }


        else if (primeInt == 300){
                 Char1name.text = "YOU";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "[Nar rumbles out a language I just can't wrap my head around. In fact, my head hurts from just hearing it.]";
         }
         else if (primeInt == 301){
                  Char1name.text = "YOU";
                  Char1speech.text = "[Something crawls out of the portal holding a paper bag that smells pretty good. Nar dishes out the necessary cash, and then I get pushed in.]";
                  Char2name.text = "";
                  Char2speech.text = "";
        }
           else if (primeInt == 302){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "KTHULU";
                    Char2speech.text = "Sorry, human. This is just how it is at this school. Learn some respect for summons.";
            }
       else if (primeInt == 303){
                Char1name.text = "YOU";
                Char1speech.text = "It was just some food delivery!!";
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
                Char2name.text = "KTHULU";
                Char2speech.text = "I would hope this is worse.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Kthulu";
                Char2speech.text = "It absolutely is necessary! You need to be taught a lesson!";
                primeInt = 199;
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
