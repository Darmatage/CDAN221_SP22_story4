using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene13_dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtNar1;
        public GameObject ArtNar2;
        public GameObject ArtKthulu;
        public GameObject ArtBG1;
        public GameObject NextScene1Button;
        public GameObject nextButton;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtNar1.SetActive(false);
        ArtBG1.SetActive(true);
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
               ArtNar1.SetActive(true);
               ArtNar2.SetActive(false);
               ArtKthulu.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "You have to stop.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "Excuse me?";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "You";
                Char1speech.text = "You have to get rid of this. Cancel the order or something.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "No, I already made the order. My phone’s already ready.";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "You";
                Char1speech.text = "This seems dangerous! You can’t just summon a demon or whatever in the middle of a classroom!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "Teach, this stuff happens all the time, go away.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "You";
                Char1speech.text = "No! Erase this circle and find some other way to get your food delivered. Isn’t there an easier way?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
      //          nextButton.SetActive(false);
      //          allowSpace = false;
          //      Choice1a.SetActive(true); // function Choice1aFunct()
          //      Choice1b.SetActive(true); // function Choice1bFunct()
        }

        else if (primeInt == 9){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Nyarlathotep";
                 Char2speech.text = "Aren’t there better jobs than being a substitute teacher?";
                 Char3name.text = "";
                 Char3speech.text = "";
               }
               else if (primeInt == 10){
                        Char1name.text = "You";
                        Char1speech.text = "It’s kids like you that make this job hard!";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                      }
                      else if (primeInt == 11){
                        ArtNar1.SetActive(false);
                        ArtNar2.SetActive(true);
                               Char1name.text = "";
                               Char1speech.text = "";
                               Char2name.text = "Nyarlathotep";
                               Char2speech.text = "Are you seriously trying to fight me on this one, human?";
                               Char3name.text = "";
                               Char3speech.text = "";
                             }

                             else if (primeInt == 12){
                                      Char1name.text = "You";
                                      Char1speech.text = ".....";
                                      Char2name.text = "";
                                      Char2speech.text = "";
                                      Char3name.text = "";
                                      Char3speech.text = "";
                                    }
                                    else if (primeInt == 13){
                                             Char1name.text = "You";
                                             Char1speech.text = "Just erase it already.";
                                             Char2name.text = "";
                                             Char2speech.text = "";
                                             Char3name.text = "";
                                             Char3speech.text = "";
                                           }
                                           else if (primeInt == 14){
                                                    Char1name.text = "You";
                                                    Char1speech.text = "[Nar still doesn’t look happy.]";
                                                    Char2name.text = "";
                                                    Char2speech.text = "";
                                                    Char3name.text = "";
                                                    Char3speech.text = "";
                                                  }
                                                  else if (primeInt == 15){
                                                           Char1name.text = "You";
                                                           Char1speech.text = "[You need backup for this one.]";
                                                           Char2name.text = "";
                                                           Char2speech.text = "";
                                                           Char3name.text = "";
                                                           Char3speech.text = "";
                                                         }
                                                         else if (primeInt == 16){
                                                                  Char1name.text = "You";
                                                                  Char1speech.text = "[You head over to the phone and call the Principal.]";
                                                                  Char2name.text = "";
                                                                  Char2speech.text = "";
                                                                  Char3name.text = "";
                                                                  Char3speech.text = "";
                                                                }
                                                                else if (primeInt == 17){
                                                                  ArtKthulu.SetActive(true);
                                                                         Char1name.text = "";
                                                                         Char1speech.text = "";
                                                                         Char2name.text = "";
                                                                         Char2speech.text = "";
                                                                         Char3name.text = "Kthulu";
                                                                         Char3speech.text = "Hello?";
                                                                       }
                                                                       else if (primeInt == 18){
                                                                                Char1name.text = "You";
                                                                                Char1speech.text = "Hi, I need a bit of backup for a situation, sir.";
                                                                                Char2name.text = "";
                                                                                Char2speech.text = "";
                                                                                Char3name.text = "";
                                                                                Char3speech.text = "";
                                                                              }
                                                                              else if (primeInt == 19){
                                                                                       Char1name.text = "";
                                                                                       Char1speech.text = "";
                                                                                       Char2name.text = "";
                                                                                       Char2speech.text = "";
                                                                                       Char3name.text = "Kthulu";
                                                                                       Char3speech.text = "Oh, the human. You need help after all?";
                                                                                     }
                                                                                     else if (primeInt == 20){
                                                                                              Char1name.text = "You";
                                                                                              Char1speech.text = "The student is refusing to stop an action, that’s all. I was hoping hearing from you would help with this.";
                                                                                              Char2name.text = "";
                                                                                              Char2speech.text = "";
                                                                                              Char3name.text = "";
                                                                                              Char3speech.text = "";
                                                                                            }
                                                                                            else if (primeInt == 21){
                                                                                                     Char1name.text = "";
                                                                                                     Char1speech.text = "";
                                                                                                     Char2name.text = "";
                                                                                                     Char2speech.text = "";
                                                                                                     Char3name.text = "Kthulu";
                                                                                                     Char3speech.text = "I’ll be one my way, then.";
                                                                                                   }
                                                                                                   else if (primeInt == 22){
                                                                                                            Char1name.text = "You";
                                                                                                            Char1speech.text = "[You turn back to Nar.] Principal’s on his way.";
                                                                                                            Char2name.text = "";
                                                                                                            Char2speech.text = "";
                                                                                                            Char3name.text = "";
                                                                                                            Char3speech.text = "";
                                                                                                          }
                                                                                                          else if (primeInt == 23){
                                                                                                                   Char1name.text = "";
                                                                                                                   Char1speech.text = "";
                                                                                                                   Char2name.text = "Nyarlathotep";
                                                                                                                   Char2speech.text = "(flippant) I don’t think this will go the way you think it will, teach.";
                                                                                                                   Char3name.text = "";
                                                                                                                   Char3speech.text = "";
                                                                                                                   nextButton.SetActive(false);
                                                                                                                   allowSpace = false;
                                                                                                                   NextScene1Button.SetActive(true);
                                                                                                                 }

                                                                                                               }
                                                                                                               public void SceneChange1(){
                                                                                                                      SceneManager.LoadScene("scene14");
                                                                                                               }

                                                                                                             }

// ENCOUNTER AFTER CHOICE #1
  //     else if (primeInt == 100){
  //              Char1name.text = "Jeda";
    //            Char1speech.text = "Then you are no use to me, and must be silenced.";
      //          Char2name.text = "";
        //        Char2speech.text = "";
  //      }
//       else if (primeInt == 101){
//                Char1name.text = "Jeda";
  //              Char1speech.text = "Come back here! Do not think you can hide from me!";
    //            Char2name.text = "";
        //        Char2speech.text = "";
      //          nextButton.SetActive(false);
          //      allowSpace = false;
            //    NextScene1Button.SetActive(true);
  //      }

//       else if (primeInt == 200){
          //      Char1name.text = "Jeda";
            //    Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
              //  Char2name.text = "";
                //Char2speech.text = "";
  //      }
//       else if (primeInt == 201){
  //              Char1name.text = "";
    //            Char1speech.text = "";
      //          Char2name.text = "You";
        //        Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
          //      nextButton.SetActive(false);
            //    allowSpace = false;
        //        NextScene2Button.SetActive(true);
//        }
//}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    //    public void Choice1aFunct(){
        //        Char1name.text = "";
      //          Char1speech.text = "";
    //            Char2name.text = "You";
      //          Char2speech.text = "I don't know what you're talking about!";
        //        primeInt = 99;
        //        Choice1a.SetActive(false);
        //        Choice1b.SetActive(false);
          //      nextButton.SetActive(true);
            //    allowSpace = true;
//        }
  //      public void Choice1bFunct(){
      //          Char1name.text = "";
      //          Char1speech.text = "";
      //          Char2name.text = "You";
      //          Char2speech.text = "Sure, anything you want... just lay off the club.";
      //          primeInt = 199;
        //        Choice1a.SetActive(false);
        //        Choice1b.SetActive(false);
      //          nextButton.SetActive(true);
        //        allowSpace = true;




  //      public void SceneChange2(){
    //            SceneManager.LoadScene("Scene2b");
