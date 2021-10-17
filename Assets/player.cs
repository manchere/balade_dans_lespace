using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float vitesseDeplacement = 10.0f;
    public float vitesseRotation = 5.0f; 
    // Start is called before the first frame update
    private float acceleration = 0.001f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moveUp();
        // moveDown();
        // moveLeft();
        // moveRight();
        moveTranslate(KeyCode.UpArrow, Vector3.forward);
        moveTranslate(KeyCode.DownArrow, Vector3.back);
        moveRotate(KeyCode.LeftArrow, Vector3.down);
        moveRotate(KeyCode.RightArrow, Vector3.up);

        // appuyer sur shift pour accelerer
        machSpeed();
       
        
    }

    void moveTranslate(KeyCode keymove, Vector3 direction)
    {
        if (Input.GetKey(keymove))
        {
            transform.Translate(direction * Time.deltaTime * vitesseDeplacement);
        }
    }

    void moveRotate(KeyCode keymove, Vector3 direction)
    {
        if (Input.GetKey(keymove))
        {
            transform.Rotate(direction * Time.deltaTime * vitesseRotation);
        }
    }

    // void moveUp()
    // {
    //     if (Input.GetKey(KeyCode.UpArrow))
    //     {
    //         transform.Translate(Vector3.forward * Time.deltaTime * vitesseDeplacement);
    //     }
    // }


    // void moveDown()
    // {
    //     if (Input.GetKey(KeyCode.DownArrow))
    //     {
    //         transform.Translate(Vector3.back * Time.deltaTime * vitesseDeplacement);
    //     }
    // }

    // void moveLeft()
    // {
    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //         transform.Rotate(Vector3.down * Time.deltaTime * vitesseRotation);
    //     }
    // }

    // void moveRight()
    // {
    //     if (Input.GetKey(KeyCode.RightArrow))
    //     {
    //         transform.Rotate(Vector3.up * Time.deltaTime * vitesseRotation);
    //     }
    // }    

    void machSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration++);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration--);
        }
    }
}
