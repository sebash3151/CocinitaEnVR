using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coocker : MonoBehaviour
{
    private float timer = 0;
    [SerializeField] private CookBehaviour cockBh = null;
    private AudioSource coockAudio;
    [SerializeField] bool started = false;

    private void Start()
    {
        coockAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (started)
        {
            timer += Time.deltaTime;
            if(timer >= 5.0)
            {
                if (cockBh != null)
                {
                    cockBh.CookActive();
                    coockAudio.Play();
                }
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        cockBh = other.GetComponent<CookBehaviour>();
        
    }

    public void StartCooking()
    {
        started = true;
    }

    private void OnTriggerExit(Collider other)
    {
        cockBh = null;
    }
}
