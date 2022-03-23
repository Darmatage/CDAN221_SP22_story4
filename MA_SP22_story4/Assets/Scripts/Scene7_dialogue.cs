using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7_dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject ArtNar1;
        public GameObject ArtBG1;
        public GameObject NextScene1Button;
        public GameObject nextButton;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtNar1.SetActive(false);
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
               ArtNar1.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Another successful student interaction. To teach really IS to change lives forever, huh? ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "[filming self] Hey Guys! It’s Nar coming to you live with the YouCraft video to top all YouCraft videos!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Wait, what’s going on over there?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "My sick summoning ritual is almost complete!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Wha- what?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nyarlathotep";
                Char2speech.text = "[pausing from filming] Ugh. Is it, like, your first day in a school ever? I’m obviously opening a portal for a delivery demon to bring the food I ordered for lunch through.";
        }
       else if (primeInt == 8){
         ArtNar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "What?! Cut that out immediately!";
                Char2name.text = "";
                Char2speech.text = "";
}
                else if (primeInt == 9){
                  ArtNar1.SetActive(true);
                   DialogueDisplay.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Nyarlathotep";
                         Char2speech.text = "[filming again] Like and subscribe if you want to see me push my annoying substitute teacher through the portal as a sick bonus prank!";
}
                         else if (primeInt == 10){
                           ArtNar1.SetActive(true);
                            DialogueDisplay.SetActive(true);
                                  Char1name.text = "You";
                                  Char1speech.text = "That’s it! I’m calling in Principal Kthulu.";
                                  Char2name.text = "";
                                  Char2speech.text = "";
}
                // Turn off "Next" button, turn on "Choice" buttons
          {      nextButton.SetActive(true);
                allowSpace = false;
//                Choice1a.SetActive(true); // function Choice1aFunct()
  //              Choice1b.SetActive(true); // function Choice1bFunct()
        }

    }

 }
