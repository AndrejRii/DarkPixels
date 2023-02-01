using System.Collections;
using UnityEngine.Tilemaps;
using UnityEngine;

public class SecretTriggerLevel3  : MonoBehaviour
{
    public TilemapRenderer FakeEnd;
    public SpriteRenderer spikes1;
    public SpriteRenderer spikes2;
    public SpriteRenderer spikes3;
    public SpriteRenderer spikes4;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FakeEnd.enabled = false;
            spikes1.enabled = false;
            spikes2.enabled = false;
            spikes3.enabled = false;
            spikes4.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FakeEnd.enabled = true;
            spikes1.enabled = true;
            spikes2.enabled = true;
            spikes3.enabled = true;
            spikes4.enabled = true;
        }
    }

}

