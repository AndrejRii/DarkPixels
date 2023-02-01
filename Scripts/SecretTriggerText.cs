using System.Collections;
using UnityEngine.Tilemaps;
using UnityEngine;

public class SecretTriggerText : MonoBehaviour
{
    public TilemapRenderer FakeWall;
    public SpriteRenderer Text2;
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))  {
            FakeWall.enabled = false;
            Text2.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            FakeWall.enabled = true;
            Text2.enabled = true;
        }        
    }

}

