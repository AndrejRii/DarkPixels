using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;             //zmeniť order layer aby z pause do main menu bola animacia a nie blackscreen?
    public float transitionTime = 1f;  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {            
             LoadNextLevel();
             Time.timeScale = 0;           
        }
    }

    IEnumerator EndGame()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(transitionTime);
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel (int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(transitionTime);
        Time.timeScale = 1;
        SceneManager.LoadScene(levelIndex);
    }

    public void PlayGame()
    {               
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex +1));
    }  

    public void QuitGame()
    {
        Application.Quit();
    }
}
