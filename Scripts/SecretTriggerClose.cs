using System.Collections;
using UnityEngine.Tilemaps;
using UnityEngine;

public class SecretTriggerClose : MonoBehaviour
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
    public GameObject Text8;
    public GameObject Spike;
    public Collider2D SpikeCollider;

    private void Start()
    {
        Wall.SetActive(false);
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Spike.SetActive(false);
        SpikeCollider.enabled = false;
    }
   

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Player")) {         
            StartCoroutine(Introduction());
            Hitbox.enabled = false;
        }
    }           

    IEnumerator Introduction() {
        yield return new WaitForSecondsRealtime(.7f);
        Wall.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Text1.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        Text1.SetActive(false);
        Text2.SetActive(true);
        yield return new WaitForSecondsRealtime(2.25f);
        Text2.SetActive(false);
        Text3.SetActive(true);
        yield return new WaitForSecondsRealtime(2.25f);
        Text3.SetActive(false);
        Text4.SetActive(true);
        yield return new WaitForSecondsRealtime(3.5f);
        Text4.SetActive(false);
        Text5.SetActive(true);
        yield return new WaitForSecondsRealtime(2.4f);
        Text5.SetActive(false);
        Text6.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        Text6.SetActive(false);
        Text7.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
        Text7.SetActive(false);
        Text8.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
        Spike.SetActive(true);
        SpikeCollider.enabled = true;        
    }
}


