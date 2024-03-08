using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coocker : MonoBehaviour
{
    private float timer = 0;
    private CookBehaviour cockBh = null;
    private AudioSource coockAudio;

    private void Start()
    {
        coockAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        cockBh = other.GetComponent<CookBehaviour>();
        
    }

    public void StartCooking()
    {
        if (cockBh != null)
        {
            cockBh.CookActive();
            coockAudio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        cockBh = null;
    }
}
