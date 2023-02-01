using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Level4 : MonoBehaviour
{
    public GameObject spikes1;
    public GameObject spikes2;
    public GameObject spikes3;

    public GameObject EndBarrier;

    void Start()
    {
        StartCoroutine(Diss());
        StartCoroutine(End());
        spikes1.SetActive(false);
        spikes2.SetActive(false);
        spikes3.SetActive(false);
        EndBarrier.SetActive(false);
    }
    
    IEnumerator Diss()
    {
        while (true) {
            yield return new WaitForSecondsRealtime(0.25f);
            spikes2.SetActive(true);
            yield return new WaitForSecondsRealtime(0.25f);
            spikes1.SetActive(false);
            yield return new WaitForSecondsRealtime(0.25f);
            spikes3.SetActive(true);
            yield return new WaitForSecondsRealtime(0.25f);
            spikes2.SetActive(false);
            yield return new WaitForSecondsRealtime(0.25f);
            spikes1.SetActive(true);
            yield return new WaitForSecondsRealtime(0.25f);
            spikes3.SetActive(false);
        }
    }

    IEnumerator End()
    {
        while (true) { 
            yield return new WaitForSecondsRealtime(Random.Range(1,9));
            EndBarrier.SetActive(true);
            yield return new WaitForSecondsRealtime(Random.Range(1, 10));
            EndBarrier.SetActive(false);

            //EndBarrier.enabled = true;
            //yield return new WaitForSecondsRealtime(5);
            //EndBarrier.enabled = false;
            //yield return new WaitForSecondsRealtime(2);

            //EndBarrier.enabled = true;
            //yield return new WaitForSecondsRealtime(8);
            //EndBarrier.enabled = false;
            //yield return new WaitForSecondsRealtime(4);

            //EndBarrier.enabled = true;
            //yield return new WaitForSecondsRealtime(2);
            //EndBarrier.enabled = false;
            //yield return new WaitForSecondsRealtime(3);

            //EndBarrier.enabled = true;
            //yield return new WaitForSecondsRealtime(8);
            //EndBarrier.enabled = false;
        }

    }
}
