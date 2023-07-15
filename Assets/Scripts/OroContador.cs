using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorOro : MonoBehaviour
{

    [SerializeField] private float oro;
    [SerializeField] private TMP_Text contador;
    [SerializeField] private float oroPorSegundo;


    // Start is called before the first frame update
    void Start()
    {
        contador = GetComponent<TMP_Text>();
        oro = 0;
        oroPorSegundo = 1.2f;
        

    }

    // Update is called once per frame
    void Update()
    {
        contador.text = (int)oro + "";
        oro += oroPorSegundo * Time.deltaTime;
    }
}
