using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamage : MonoBehaviour
{
    //public Animator transition; 
    //public float transitionTime = 1f;   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {            
            HealthCheck.health -= 1;

            if (HealthCheck.health == 0) {            
                Time.timeScale = 0;                
            }
            else {            
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
                Time.timeScale = 1;
            }
        }
    }
    //IEnumerator LoadLevel(int levelIndex)
    //{
    //    transition.SetTrigger("Start");
    //    yield return new WaitForSecondsRealtime(transitionTime);
    //    Time.timeScale = 1;
    //    SceneManager.LoadScene(levelIndex);        
    //}
}
