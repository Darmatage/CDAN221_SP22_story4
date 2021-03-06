using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene14_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
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
        public GameObject DialogueDisplay;
        public GameObject ArtKthulu;
        public GameObject ArtNar;
        public GameObject ArtYog;
        public GameObject ArtDagon;
        public GameObject ArtBG1;
        //public GameObject Choice1a;
        //public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtKthulu.SetActive(false);
        ArtNar.SetActive(false);
        ArtYog.SetActive(false);
        ArtDagon.SetActive(false);
        ArtBG1.SetActive(true);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
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
        else if (primeInt ==2){
                DialogueDisplay.SetActive(true);
                 ArtKthulu.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Principal Kthulu";
                 Char2speech.text = "How???s everything going in here?";
                 nextButton.SetActive(true);
         }
        else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "Uh, well Sir, considering I just put a stop to some sort of rune fabrication, and a deadly portal, I???d say things are going... off track.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Principal Kthulu";
                Char2speech.text = "What did you just say?! Are you intentionally trying to stifle my students?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "What? No, I just thought-";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Principal Kthulu";
                Char2speech.text = "Pfft. A deadly portal. You humans are all the same, total lack of creativity. These young pupils deserve a safe school environment to work on hone their crafts and shine!";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7){
                 Char1name.text = "YOU";
                 Char1speech.text = "Sir, I-";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Principal Kthulu";
                Char2speech.text = "BUT because this is your first day, I'll grant you this one mistake.";
        }
        else if (primeInt == 9){
                 Char1name.text = "YOU";
                 Char1speech.text = "Thank you sir!";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 10){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Principal Kthulu";
                  Char2speech.text = "Of course, just this once.";
         }
       else if (primeInt ==11){
         ArtKthulu.SetActive(false);
         ArtNar.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Nar";
                Char3speech.text = "Ha! Suck it human- wait, you're not going to fire them?";
        }
        else if (primeInt ==12){
          ArtKthulu.SetActive(true);
          ArtNar.SetActive(false);
                 Char1name.text = "Principal Kthulu";
                 Char1speech.text = "No.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
        else if (primeInt ==13){
          ArtKthulu.SetActive(false);
          ArtNar.SetActive(false);
          ArtYog.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "Yog";
                 Char4speech.text = "Your karmic vengeance shall be swift and sure!";
         }
         else if (primeInt ==14){
           ArtYog.SetActive(false);
           ArtDagon.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "Dagon";
                  Char5speech.text = "See you later, loser!";
          }
        else if (primeInt == 15){
            ArtDagon.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "I cannot believe I came in hungover on a Monday morning and still survived Eldrich God detention.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
                 Char5name.text = "";
                 Char5speech.text = "";
        }
        else if (primeInt == 16){
            ArtDagon.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "...Survived and kept the job no less!";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
                 Char5name.text = "";
                 Char5speech.text = "";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 NextScene1Button.SetActive(true);
                 //NextScene2Button.SetActive(true);
        }
      }
// ENCOUNTER AFTER CHOICE #1
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void SceneChange1(){
               SceneManager.LoadScene("End_Win");
        }
      }
