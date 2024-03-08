using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMaker : MonoBehaviour
{
    private EatBehaviour eat;
    [SerializeField] ParticleSystem particles;
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tazas"))
        {
            eat = other.GetComponent<EatBehaviour>();
            eat.Rellenar();
            if (!audio.isPlaying)
            {
                audio.Play();
            }
            particles.Play();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        eat = null;
        particles.Stop();
        audio.Stop();
    }
}
