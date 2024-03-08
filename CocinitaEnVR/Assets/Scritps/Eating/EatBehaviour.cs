using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatBehaviour : MonoBehaviour
{
    [SerializeField] bool restos = false;
    [SerializeField] public GameObject objeto;
    [SerializeField] Material transparentMat;
    private MeshRenderer meshRendererObject;
    

    private AudioSource audioSource;

    [SerializeField] GameObject objectReserve;
    [SerializeField] bool vaso = false;

    public bool comido = false;
    private float timer = 0;

    [SerializeField] MeshRenderer meshRendererObject2;
    [SerializeField] MeshRenderer meshRendererObject3;
    [SerializeField] MeshRenderer meshRendererObject4;

    [SerializeField] Material normalMat;

    void Start()
    {
        meshRendererObject = objectReserve.GetComponent<MeshRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (comido && !restos)
        {
            timer += Time.deltaTime;
            if (timer >= 10)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Rellenar()
    {
        comido = false;
        meshRendererObject.material = normalMat;
        meshRendererObject2.material = normalMat;
        meshRendererObject3.material = normalMat;
        meshRendererObject4.material = normalMat;
        objeto.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Eat"))
        {
            if (!comido)
            {
                comido = true;
                audioSource.Play();
                meshRendererObject.material = transparentMat;
                meshRendererObject2.material = transparentMat;
                meshRendererObject3.material = transparentMat;
                meshRendererObject4.material = transparentMat;
                if (restos)
                {
                    objeto.SetActive(true);
                }
            }
        }
    }
}
