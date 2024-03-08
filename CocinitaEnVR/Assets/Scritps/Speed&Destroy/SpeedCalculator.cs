using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCalculator : MonoBehaviour
{
    public float speed;
    public float limitSpeedToExplode = 3;

    void Update()
    {
        StartCoroutine(CalculateSpeed());
    }
    IEnumerator CalculateSpeed() 
    {
        Vector3 lastPosition = transform.position;
        yield return new WaitForFixedUpdate();
        speed = (lastPosition - transform.position).magnitude / Time.deltaTime;
    }
}
