using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChange : MonoBehaviour {
    
    public GameObject Text1;
    public GameObject Text2;
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
        }
    }
    private void Update()
    {
        HealthCheck.health = 5;
    }
}
