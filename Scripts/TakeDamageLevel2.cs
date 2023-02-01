using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamageLevel2 : MonoBehaviour
{

    public SpriteRenderer spikes1;
    public SpriteRenderer spikes2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthCheck.health -= 1;

            if (HealthCheck.health == 0)
            {
                Time.timeScale = 0;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }

    private void Start()
    {
        StartCoroutine("ShowSpikes");
    }

    IEnumerator ShowSpikes()
    {
        while (true)
        {
            spikes1.enabled = true;
            spikes2.enabled = true;
            yield return new WaitForSecondsRealtime(.5f);
            spikes1.enabled = false;
            spikes2.enabled = false;
            yield return new WaitForSecondsRealtime(5);
        }
       
    }
}    
