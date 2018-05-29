using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UnityStandardAssets.Characters.FirstPerson
{
    public class pauzescherm : MonoBehaviour
    {



        public Button mybutton;



        public GameObject firstpscript;
        public GameObject on;

        [SerializeField]
        private GameObject pausePanel;
        void Start()
        {
            pausePanel.SetActive(false);

            Button buttonn = mybutton.GetComponent<Button>();
            buttonn.onClick.AddListener(ContinueGame);

        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!pausePanel.activeInHierarchy)
                {
                    PauseGame();
                }
                else if (pausePanel.activeInHierarchy)
                {
                    ContinueGame();
                }
            }
        }



       
        
        private void PauseGame()
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            //Disable scripts that still work while timescale is set to 0  
            FirstPersonController firstpcon = firstpscript.GetComponent<FirstPersonController>();
            firstpcon.enabled = false;
            playerer player = firstpscript.GetComponent<playerer>();
            player.enabled = false;
            Cursor.visible = true;   
        }
        private void ContinueGame()
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            //enable the scripts again
            FirstPersonController firstpcon = firstpscript.GetComponent<FirstPersonController>();
            firstpcon.enabled = true;
            playerer player = firstpscript.GetComponent<playerer>();
            player.enabled = true;
            Cursor.visible = false;
        }

    }
}