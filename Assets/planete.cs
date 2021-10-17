using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planete : MonoBehaviour
{
    public float vitesseRotation;
    public float vitesseTournerAutour;
    public Transform centre;
    
    void Start()
    {
        
    }

    void Update()
    {
        planeteRotation();
        rotateAround();
    }

    void planeteRotation() 
    {
        transform.Rotate(Vector3.up * vitesseRotation * Time.deltaTime);
    }
    
    void rotateAround()
    {
        transform.RotateAround(centre.position, Vector3.up, vitesseTournerAutour * Time.deltaTime);
    }

}
