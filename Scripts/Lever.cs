using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject StartTilemap;

    public Sprite LeverOFF;
    public Sprite LeverON;
    public GameObject Tilemap;
    public SpriteRenderer LeverSpriteRenderer;

    void Start()
    {
        StartTilemap.SetActive(true);
        Invoke("StartLevel",2);
    }

    void StartLevel()
    {
        StartTilemap.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (LeverSpriteRenderer.sprite == LeverOFF)
            {
                LeverSpriteRenderer.sprite = LeverON;
                Tilemap.SetActive(false);
                FindObjectOfType<AudioManager>().Play("LeverON");
            } else if (LeverSpriteRenderer.sprite == LeverON)
            {
                LeverSpriteRenderer.sprite = LeverOFF;
                Tilemap.SetActive(true);
                FindObjectOfType<AudioManager>().Play("LeverOFF");
            }
        }
    }
}
