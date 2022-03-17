using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene15_Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
        //public Text Char5name;
        //public Text Char5speech;

        //public Text Char3name;
        //public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtKthulu1;
        public GameObject ArtDagon1;
        public GameObject ArtYog1;
        public GameObject ArtNar1;
        public GameObject ArtBG1;
        //public GameObject Choice1a;
        //public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        //public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtKthulu1.SetActive(false);
        ArtDagon1.SetActive(false);
        ArtYog1.SetActive(false);
        ArtNar1.SetActive(false);
        ArtBG1.SetActive(true);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        //NextScene3Button.SetActive(false);
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
               ArtKthulu1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "Kthulu";
                Char1speech.text = "I shouldn’t have hired a human to watch over the three of you today.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";


        }
        else if (primeInt == 3){
               ArtKthulu1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "Nyarlathotep";
                Char1speech.text = "Don’t worry about it, Mister Kthulu! This is just a lesson learned for all of us.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 4){
               ArtKthulu1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "Kthulu";
                Char1speech.text = "I just don’t understand the choices that led to this.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 5){
               ArtKthulu1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "Dagon";
                Char1speech.text = "Well, I guess this means no more humans at the school. Even if they seem kind of cool.. I guess.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==6){
              ArtKthulu1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "Yog";
                Char1speech.text = "The human was of no use at our school.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7){
               ArtKthulu1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "Kthulu";
                Char1speech.text = "...In any case, I apologize for such poor supervision.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt ==8){
               ArtKthulu1.SetActive(true);
                 dialogue.SetActive(true);
                 Char1name.text = "Nyarlathotep";
                 Char1speech.text = "Oh well. You want some Demonic Nuggets? I ordered a bunch.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 //gameHandler.AddPlayerStat(1);
         }
         else if (primeInt == 9){
                ArtKthulu1.SetActive(true);
                 dialogue.SetActive(true);
                 Char1name.text = "Kthulu";
                 Char1speech.text = "Why not?";
                 Char2name.text = "";
                 Char2speech.text = "";
         }

}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        // public void Choice1aFunct(){
        //       ArtKthulu1.SetActive(true);
        //         dialogue.SetActive(true);
        //         Char1name.text = "";
        //         Char1speech.text = "";
        //         Char2name.text = "Kthulu";
        //         Char2speech.text = "Excellent.";
        //         primeInt = 99;
        //         Choice1a.SetActive(false);
        //         Choice1b.SetActive(false);
        //         nextButton.SetActive(true);
        //         allowSpace = true;
        // }
        // public void Choice1bFunct(){
        //       ArtKthulu1.SetActive(true);
        //         dialogue.SetActive(true);
        //         Char1name.text = "";
        //         Char1speech.text = "";
        //         Char2name.text = "Kthulu";
        //         Char2speech.text = "This isn't like your human detentions.";
        //         primeInt = 99;
        //         Choice1a.SetActive(false);
        //         Choice1b.SetActive(false);
        //         nextButton.SetActive(true);
        //         allowSpace = true;
        // }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose");
        }
        //public void SceneChange2(){
                //SceneManager.LoadScene("Scene2b");
        //}
        //public void SceneChange3(){
                //SceneManager.LoadScene("Scene2c");
              //}
}
