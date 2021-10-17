using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraplayer : MonoBehaviour
{
    public Transform joueur;
    public float vitesse;

    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 ciblePos = joueur.position;
        ciblePos.y = transform.position.y;

        transform.position = Vector3.Lerp(transform.position, ciblePos, vitesse * Time.deltaTime);
    }
}
