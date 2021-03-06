using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2_Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;

        //public Text Char3name;
        //public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtDagon1;
        public GameObject ArtDagon2;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
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
        ArtDagon1.SetActive(false);
        ArtDagon2.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
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
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "[Approaching Dagon as she???s messing with the classroom sink.]";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
               ArtDagon1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "There???s a water fountain out in the hall if you???re thirsty.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 4){
               ArtDagon1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "...";
        }
        else if (primeInt == 5){
               ArtDagon1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "???Alright, what are you trying to do over here then?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
              ArtDagon1.SetActive(false);
              ArtDagon2.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dagon";
                Char2speech.text = "Wouldn't you like to know.";
              }
             else if (primeInt == 7){
                    ArtDagon2.SetActive(true);
                      dialogue.SetActive(true);
                      Char1name.text = "YOU";
                      Char1speech.text = "[Would you like to know?]";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Choice1a.SetActive(true); // function Choice1aFunct()
                      NextScene1Button.SetActive(true);
                      nextButton.SetActive(false);
              }
              else if (primeInt == 8){
                     ArtDagon2.SetActive(true);
                       dialogue.SetActive(true);
                       Char1name.text = "YOU";
                       Char1speech.text = "So, water stuff, huh? Have you considered the school???s swim team?";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Choice1a.SetActive(false); // function Choice1aFunct()
                       NextScene1Button.SetActive(false);
                      nextButton.SetActive(true);
               }
               else if (primeInt == 9){
                      ArtDagon2.SetActive(false);
                      ArtDagon1.SetActive(true);
                        dialogue.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Dagon";
                        Char2speech.text = "What? That???s like, so offensive??? (and way below my skill level).";
                        nextButton.SetActive(true);
                }
                else if (primeInt == 10){
                       ArtDagon1.SetActive(true);
                         dialogue.SetActive(true);
                         Char1name.text = "YOU";
                         Char1speech.text = "Sorry, that???s my mistake for assuming. I just wasn???t sure if Mother Hydra supported extracurricular activities.";
                         Char2name.text = "";
                         Char2speech.text = "";
                 }
                 else if (primeInt ==11){
                        ArtDagon1.SetActive(false);
                        ArtDagon2.SetActive(true);
                          dialogue.SetActive(true);
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "Dagon";
                          Char2speech.text = "You know Mother Hydra?";
                  }

                   else if (primeInt ==12){
                     ArtBG1.SetActive(false);
                     ArtBG2.SetActive(true);
                          ArtDagon1.SetActive(false);
                          ArtDagon2.SetActive(false);
                            dialogue.SetActive(true);
                            Char1name.text = "YOU";
                            Char1speech.text = "[You notice her growing excitement makes the sink start to rumble. If you don???t do something now, it might burst!]";
                            Char2name.text = "";
                            Char2speech.text = "";
                            NextScene2Button.SetActive(true);
                            NextScene3Button.SetActive(true);
                            nextButton.SetActive(false);
                    }
                //gameHandler.AddPlayerStat(1);


}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)



        public void SceneChange1(){
               SceneManager.LoadScene("Scene1");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene6");
        }
}
