using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9_dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject ArtYog1;
        public GameObject ArtBG1;
        public GameObject NextScene1Button;
        public GameObject nextButton;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtYog1.SetActive(false);
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
               ArtYog1.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Well, maybe I could help you!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
         ArtYog1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Yog-Sothoth";
                Char2speech.text = "What does a human like you know about crafting runes?";
                //gameHandler.AddPlayerStat(1);
        }

       else if (primeInt == 4){
         ArtYog1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
         ArtYog1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
        ArtYog1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
         ArtYog1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
         ArtYog1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
}
                else if (primeInt == 9){
                  ArtYog1.SetActive(true);
                   DialogueDisplay.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
}
                         else if (primeInt == 10){
                           ArtYog1.SetActive(true);
                            DialogueDisplay.SetActive(true);
                                  Char1name.text = "You";
                                  Char1speech.text = "";
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
