using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollide : MonoBehaviour {

 
    private void OnTriggerEnter2D(Collider2D collision) {

        Invoke("wait", 0.5f);

    }

    private void OnCollisionEnter2D(Collision2D collision) {

        Invoke("wait", 0.5f);

    }

    void wait()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


 }
