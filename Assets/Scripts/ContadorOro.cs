using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorOro : MonoBehaviour
{

    [SerializeField] private float oro;
    [SerializeField] private Text contador;
    [SerializeField] private float oroPorSegundo;


    // Start is called before the first frame update
    void Start()
    {
        contador = GetComponent<Text>();
        oro = 0;
        oroPorSegundo = 1f;
        

    }

    // Update is called once per frame
    void Update()
    {
        contador.text = (int)oro + "";
        oro += oroPorSegundo * Time.deltaTime;
    }
}
