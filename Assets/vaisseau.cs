using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaisseau : MonoBehaviour
{
    public Transform planete1;
    public Transform planete2;
    public float distanceMin = 2f;
    public float vitesse;
    private bool surplanete1 = false; 
    private bool surplanete2 = true ;
    private float distance;
    
    void Start()
    {
        
    }

    void Update()
    {
        roundTrip();
    }

    //Aller retour
    void roundTrip()
    {
        if (surplanete2)
        {
            movementTowards(planete1, true, false);
        }
        else if (surplanete1)
       {
            movementTowards(planete2, false, true);
       }
    }

    // distance parcouru entre le vaisseau et la planete
    float distanceCovered(Transform laplanete)
    { 
        return distance = Vector3.Distance(transform.position, laplanete.position);
    }


    void movementTowards(Transform laplanete, bool surplan1, bool surplan2)
    {
        transform.position = Vector3.MoveTowards(transform.position, laplanete.position, vitesse * Time.deltaTime);
        if (distanceCovered(laplanete) < distanceMin)
        {
            surplanete1 = surplan1;
            surplanete2 = surplan2;
        }
    }
}

