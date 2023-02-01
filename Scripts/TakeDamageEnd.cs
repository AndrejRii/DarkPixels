using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamageEnd : MonoBehaviour
{
    public Animator transition;
    public GameObject healthcheck;
    public GameObject heart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            healthcheck.SetActive(false);
            heart.SetActive(false);
            StartCoroutine(EndGame());            
        }
    }

    IEnumerator EndGame()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

}
