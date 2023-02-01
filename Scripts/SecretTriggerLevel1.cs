using System.Collections;
using UnityEngine.Tilemaps;
using UnityEngine;

public class SecretTriggerLevel1 : MonoBehaviour
{
    public BoxCollider2D Hitbox;
    public GameObject Wall;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Spike;


    private void Start()
    {
        Wall.SetActive(false);
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Spike.SetActive(false);
        Text4.SetActive(true);
        Text5.SetActive(false);
    }
   

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Player")) {         
            StartCoroutine(Introduction());
            Hitbox.enabled = false;
        }
    }           

    IEnumerator Introduction() {
        Wall.SetActive(true);
        Text4.SetActive(false);
        Text5.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Text1.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        Text1.SetActive(false);
        Text2.SetActive(true);
        yield return new WaitForSecondsRealtime(2.5f);
        Text2.SetActive(false);
        Text3.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
        Spike.SetActive(true);        
    }
}


