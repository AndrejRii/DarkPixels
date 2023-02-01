using System.Collections;
using UnityEngine.Tilemaps;
using UnityEngine;

public class SecretTriggerEnd : MonoBehaviour
{
    public BoxCollider2D Hitbox;
    public GameObject Wall;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Spike;

    private void Start()
    {
        Wall.SetActive(false);
    }
   

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Player")) {         
            StartCoroutine(Introduction());
            Hitbox.enabled = false;
        }
    }           

    IEnumerator Introduction() {
        yield return new WaitForSecondsRealtime(.5f);
        Wall.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Text1.SetActive(true);
        yield return new WaitForSecondsRealtime(2.25f);
        Text1.SetActive(false);
        Text2.SetActive(true);
        yield return new WaitForSecondsRealtime(2.75f);
        Text2.SetActive(false);
        Text3.SetActive(true);
        yield return new WaitForSecondsRealtime(2.75f);
        Text3.SetActive(false);
        Text4.SetActive(true);
        yield return new WaitForSecondsRealtime(3.75f);
        Text4.SetActive(false);
        Text5.SetActive(true);
        HealthCheck.health = 1;
        yield return new WaitForSecondsRealtime(2.75f);
        Text5.SetActive(false);
        Text6.SetActive(true);
        yield return new WaitForSecondsRealtime(2.25f);
        Text6.SetActive(false);
        Text7.SetActive(true);               
        yield return new WaitForSecondsRealtime(5);
        Spike.SetActive(true);
    }
}


