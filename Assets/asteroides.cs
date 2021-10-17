using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroides : MonoBehaviour
{
    private Vector3 axe = Vector3.zero;
    void Update()
    {
        asteroidRotate();
        randomAxe(-90, 360);
    }

    void asteroidRotate()
    {
        transform.Rotate(axe * Time.deltaTime);
    }

    void randomAxe(int start, int stop)
    {
        axe.x = Random.Range(start, stop);
        axe.y = Random.Range(start, stop);
        axe.z = Random.Range(start, stop);
    }
}
