using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookBehaviour : MonoBehaviour
{
    [SerializeField] Material materialCoocked;
    [SerializeField] Material materialBurnt;
    private MeshRenderer meshRenderer;
    public bool Coocked = false;

    [SerializeField] bool toast = false;
    [SerializeField] MeshRenderer meshRenderer2;
    [SerializeField] MeshRenderer meshRenderer3;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void CookActive()
    {
        if (!Coocked)
        {
            meshRenderer.material = materialCoocked;
            Coocked = true;
            if (toast)
            {
                meshRenderer2.material = materialCoocked;
                meshRenderer3.material = materialCoocked;
            }
        }
    }
}
