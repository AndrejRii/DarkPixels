using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void Playsound()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}
