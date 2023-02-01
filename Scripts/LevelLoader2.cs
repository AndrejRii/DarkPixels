using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class LevelLoader2 : MonoBehaviour
{

    public Animator transition;             //zmeniť order layer aby z pause do main menu bola animacia a nie blackscreen?
    public float transitionTime = 1f;

    public TilemapRenderer platform1;
    public TilemapRenderer platform2;
    public TilemapRenderer platform3;
    public TilemapRenderer platform4;
    public TilemapRenderer platform5;
    public TilemapRenderer platform6;
    public TilemapRenderer platform7;
    public SpriteRenderer spikes1;
    public SpriteRenderer spikes2;
    public SpriteRenderer spikes3;
    public SpriteRenderer spikes4;
    public SpriteRenderer spikes5;
    public SpriteRenderer spikes6;



    private void Start()
    {
        StartCoroutine(Platforms());
        platform1.enabled = false;
        platform2.enabled = false;
        platform3.enabled = false;
        platform4.enabled = false;
        platform5.enabled = false;
        platform6.enabled = false;
        platform7.enabled = false;
        spikes1.enabled = false;
        spikes2.enabled = false;
        spikes3.enabled = false;
        spikes4.enabled = false;
        spikes5.enabled = false;
        spikes6.enabled = false;
    }

    IEnumerator Platforms ()
    {
        while (true) { 
            yield return new WaitForSecondsRealtime(3);
            platform1.enabled = true;
            yield return new WaitForSecondsRealtime(.15f);
            platform1.enabled = false;
            yield return new WaitForSecondsRealtime(.8f);
            platform2.enabled = true;
            yield return new WaitForSecondsRealtime(.15f);
            platform2.enabled = false;
            yield return new WaitForSecondsRealtime(.8f);
            platform3.enabled = true;
            platform4.enabled = true;
            yield return new WaitForSecondsRealtime(.15f);
            platform3.enabled = false;
            platform4.enabled = false;            
            yield return new WaitForSecondsRealtime(.8f);
            platform5.enabled = true;
            yield return new WaitForSecondsRealtime(.15f);
            platform5.enabled = false;
            yield return new WaitForSecondsRealtime(.8f);
            platform6.enabled = true;
            spikes1.enabled = true;
            spikes2.enabled = true;
            spikes3.enabled = true;
            spikes4.enabled = true;
            spikes5.enabled = true;
            spikes6.enabled = true;
            yield return new WaitForSecondsRealtime(.15f);
            platform6.enabled = false;
            spikes1.enabled = false;
            spikes2.enabled = false;
            spikes3.enabled = false;
            spikes4.enabled = false;
            spikes5.enabled = false;
            spikes6.enabled = false;
            yield return new WaitForSecondsRealtime(.8f);
            platform7.enabled = true;
            yield return new WaitForSecondsRealtime(.15f);
            platform7.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadNextLevel();
            Time.timeScale = 0;
        }
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
