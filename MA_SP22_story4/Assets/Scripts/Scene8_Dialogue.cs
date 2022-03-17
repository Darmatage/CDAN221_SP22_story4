using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8_dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject ArtNar1;
        public GameObject ArtDagon1;
        public GameObject ArtYog1;
        public GameObject ArtBG1;
        public GameObject NextScene1Button;
        public GameObject nextButton;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtBG1.SetActive(true);
      //  Choice1a.SetActive(false);
      //  Choice1b.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "[The sink has burst; water is gushing everywhere]";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
         ArtDagon1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char3name.text = "Daegon";
                Char3speech.text = "Ha HA! That’ll show them just how powerful I really am!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "Wow Dags, I didn't think you had it in you.";
        }
       else if (primeInt == 5){
         ArtYog1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char4name.text = "Yog-Sothoth";
                Char4speech.text = "GAH! You fools! This childish display has washed away all my runes!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "…I always thought working the front desk at a dental office seemed like a decent career…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char3name.text = "Daegon";
                Char3speech.text = "Bask in the light of my glorious aquatic strength!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "Your glorious aquatic strength is getting all over my vlogging equipment.";
}
                else if (primeInt == 9){
                  ArtYog1.SetActive(true);
                   DialogueDisplay.SetActive(true);
                         Char4name.text = "Yog-Sothoth";
                         Char4speech.text = "I can’t believe this. I’ll have to start all over! The Oldest Ones are gonna kill me…";
                         Char2name.text = "";
                         Char2speech.text = "";
}
                         else if (primeInt == 10){
                           ArtNar1.SetActive(true);
                            DialogueDisplay.SetActive(true);
                                  Char1name.text = "You";
                                  Char1speech.text = "The who..?";
                                  Char2name.text = "";
                                  Char2speech.text = "";
}
else if (primeInt == 11){
  ArtNar1.SetActive(true);
   DialogueDisplay.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Nyarlathotep";
         Char2speech.text = "How are my fans supposed to watch the sick footage of me summoning a demon with my camera all soggy like this?";
       }
       else if (primeInt == 12){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "I’m sorry, sick footage of you doing WHAT?";
                Char2name.text = "";
                Char2speech.text = "";
              }
              else if (primeInt == 13){
                ArtNar1.SetActive(true);
                 DialogueDisplay.SetActive(true);
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "Nyarlathotep";
                       Char2speech.text = "Ugh, I forgot the human substitute was still here.";
                     }
                     else if (primeInt == 14){
                       ArtNar1.SetActive(true);
                        DialogueDisplay.SetActive(true);
                              Char1name.text = "You";
                              Char1speech.text = "How did I prioritize addressing some light rain showers over those other two…";
                              Char2name.text = "";
                              Char2speech.text = "";
                            }
                // Turn off "Next" button, turn on "Choice" buttons
          {      nextButton.SetActive(false);
                allowSpace = false;
//                Choice1a.SetActive(true); // function Choice1aFunct()
  //              Choice1b.SetActive(true); // function Choice1bFunct()
        }

    }

 }
