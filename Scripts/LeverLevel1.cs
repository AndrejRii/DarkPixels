using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLevel1 : MonoBehaviour
{    
    public Sprite LeverON;
    public Rigidbody2D spikes;
    public SpriteRenderer LeverSpriteRenderer;

    void Start()
    {
        spikes.simulated = false;        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LeverSpriteRenderer.sprite = LeverON;
            spikes.simulated = true;
            FindObjectOfType<AudioManager>().Play("LeverON");
        }
    }
}
