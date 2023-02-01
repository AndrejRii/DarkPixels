using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HealthCheck : MonoBehaviour {

    public static int health = 5;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;
    public Animator transition;   
    public float transitionTime = 1f; 

    public void Update()
    {        
    
        if (health == 5)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(true);
        }
        else if (health == 4)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(false);
        }
        else if (health == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(false);
            Heart5.SetActive(false);
        }
        else if (health == 2)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(false);
            Heart4.SetActive(false);
            Heart5.SetActive(false);
        }
        else if (health == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
            Heart4.SetActive(false);
            Heart5.SetActive(false);
        }
        else if (health <= 0)
        {
            StartCoroutine(LoadLevel("Level 1"));    
        }    
    }
    IEnumerator LoadLevel(string levelName)
    {       
        transition.SetTrigger("Start");
        //AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(levelName);
        //asyncOperation.allowSceneActivation = false;
        yield return new WaitForSecondsRealtime(transitionTime);        
        Time.timeScale = 1;
        health = 5;
        SceneManager.LoadScene(levelName);
        //asyncOperation.allowSceneActivation = true;
        //transition.SetTrigger("End");
        //yield return new WaitForSecondsRealtime(1);
        
        
        
    }


}

            

 