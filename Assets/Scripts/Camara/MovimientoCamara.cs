using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{

    [SerializeField] private float velocidadCamara = 50f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            transform.Translate(new Vector3(-velocidadCamara * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(velocidadCamara * Time.deltaTime, 0, 0));
        }
    }
    
}
