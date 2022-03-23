using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtNarNormal;
        public GameObject ArtNarAngry1;
        public GameObject ArtNarAngry2;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtNarNormal.SetActive(false);
        ArtNarAngry1.SetActive(false);
        ArtNarAngry2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
                Char1name.text = "YOU";
                Char1speech.text = "[Hm, what's that student doing...]";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtNarNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nar";
                Char2speech.text = "Alright, let’s get the chalk in place now.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "[He's drawing a massive chalk circle on the floor...]";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nar";
                Char2speech.text = "Perfect.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Hey, what’s going on here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
         ArtNarNormal.SetActive(false);
         ArtNarAngry1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nar";
                Char2speech.text = "Nothing much, teach. Why don’t you hurry along and check in with someone else?";
        }
       else if (primeInt == 8){
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
         ArtNarAngry1.SetActive(false);
         ArtNarAngry2.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "But seriously, what are you doing?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
        else if (primeInt == 101){
          ArtNarAngry2.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Nar";
                 Char2speech.text = "A prank.";
     }
     else if (primeInt == 102){
       ArtNarAngry2.SetActive(true);
              Char1name.text = "YOU";
              Char1speech.text = "What kind of prank?";
              Char2name.text = "";
              Char2speech.text = "";
    }
    else if (primeInt == 103){
      ArtNarAngry2.SetActive(false);
      ArtNarNormal.SetActive(true);
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Nar";
             Char2speech.text = "It’s pretty casual, really. I ordered some food and I gotta make sure it gets to the right place.";
   }
   else if (primeInt == 104){
            Char1name.text = "YOU";
            Char1speech.text = "How’s this food supposed to arrive?";
            Char2name.text = "";
            Char2speech.text = "";
  }
  else if (primeInt == 105){
    ArtNarNormal.SetActive(false);
    ArtNarAngry1.SetActive(true);
           Char1name.text = "";
           Char1speech.text = "";
           Char2name.text = "Nar";
           Char2speech.text = "Through the portal.";
 }
 else if (primeInt == 106){
          Char1name.text = "YOU";
          Char1speech.text = "The- The what?";
          Char2name.text = "";
          Char2speech.text = "";
}
else if (primeInt == 107){
  ArtNarAngry1.SetActive(false);
  ArtNarAngry2.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Nar";
         Char2speech.text = "The portal. That the delivery demon’s going to come out of.";
}
else if (primeInt == 108){
         Char1name.text = "YOU";
         Char1speech.text = "The delivery demon is going to come out of a portal?";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 109){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Nar";
         Char2speech.text = "Yes. Now, go away. Can’t have a human messing up my video.";
}
else if (primeInt == 110){
         Char1name.text = "YOU";
         Char1speech.text = "";
         Char2name.text = "";
         Char2speech.text = "";
         nextButton.SetActive(false);
         allowSpace = false;
         NextScene1Button.SetActive(true);
         NextScene2Button.SetActive(true);
}

else if (primeInt == 200){
  ArtNarAngry1.SetActive(false);
  ArtNarAngry2.SetActive(true);
         Char1name.text = "YOU";
         Char1speech.text = "But seriously, what are you doing?";
         Char2name.text = "";
         Char2speech.text = "";
         nextButton.SetActive(true);
         allowSpace = false;
         NextScene1Button.SetActive(false);
 }
 else if (primeInt == 201){
   ArtNarAngry2.SetActive(true);
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "Nar";
          Char2speech.text = "A prank.";
}
else if (primeInt == 202){
ArtNarAngry2.SetActive(true);
       Char1name.text = "YOU";
       Char1speech.text = "What kind of prank?";
       Char2name.text = "";
       Char2speech.text = "";
}
else if (primeInt == 203){
ArtNarAngry2.SetActive(false);
ArtNarNormal.SetActive(true);
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "Nar";
      Char2speech.text = "It’s pretty casual, really. I ordered some food and I gotta make sure it gets to the right place.";
}
else if (primeInt == 204){
     Char1name.text = "YOU";
     Char1speech.text = "How’s this food supposed to arrive?";
     Char2name.text = "";
     Char2speech.text = "";
}
else if (primeInt == 205){
ArtNarAngry1.SetActive(true);
    Char1name.text = "";
    Char1speech.text = "";
    Char2name.text = "Nar";
    Char2speech.text = "Through the portal.";
}
else if (primeInt == 206){
   Char1name.text = "YOU";
   Char1speech.text = "The- The what?";
   Char2name.text = "";
   Char2speech.text = "";
}
else if (primeInt == 207){
ArtNarAngry1.SetActive(false);
ArtNarAngry2.SetActive(true);
  Char1name.text = "";
  Char1speech.text = "";
  Char2name.text = "Nar";
  Char2speech.text = "The portal. That the delivery demon’s going to come out of.";
}
else if (primeInt == 208){
  Char1name.text = "YOU";
  Char1speech.text = "The delivery demon is going to come out of a portal?";
  Char2name.text = "";
  Char2speech.text = "";
}
else if (primeInt == 209){
  Char1name.text = "";
  Char1speech.text = "";
  Char2name.text = "Nar";
  Char2speech.text = "Yes. Now, go away. Can’t have a human messing up my video.";
}
else if (primeInt == 210){
  Char1name.text = "YOU";
  Char1speech.text = "";
  Char2name.text = "";
  Char2speech.text = "";
  nextButton.SetActive(false);
  allowSpace = false;
  NextScene1Button.SetActive(true);
  NextScene2Button.SetActive(true);
}
}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nar";
                Char2speech.text = "Yeah, I get that a lot.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Nar";
                Char2speech.text = "Yeah... Suuure.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene11");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene13");
        }
      }
