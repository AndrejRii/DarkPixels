using System.Collections;
using UnityEngine.Tilemaps;
using UnityEngine;

public class SecretTrigger : MonoBehaviour
{
    public TilemapRenderer FakeWall;
    
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))  {
            FakeWall.enabled = false;         
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            FakeWall.enabled = true;            
        }        
    }

}

