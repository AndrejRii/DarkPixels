using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public Animator transition;       //zaciatok zmenit starting resolution v unity  
    public float transitionTime = 1f;
    public GameObject pauseOptions;
    public GameObject promptMenu;

    private void Start()
    {
        Time.timeScale = 1;        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseMenu.activeSelf && !pauseOptions.activeSelf && !promptMenu.activeSelf) 
            { 
                pauseMenu.SetActive(true);
                Time.timeScale = 0;               

            } else if (pauseMenu.activeSelf && !pauseOptions.activeSelf && !promptMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
            }          

        }
        
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;       
    }
    public void GoMenu()
    {      
        StartCoroutine(LoadLevel(0));
        //pauseMenu.SetActive(false);  
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(transitionTime);
        SceneManager.LoadScene(levelIndex);
        Time.timeScale = 1;
    }

}
