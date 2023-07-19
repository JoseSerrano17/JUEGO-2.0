using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorOro : Contador
{

    [SerializeField] private float gold;
    [SerializeField] private TMP_Text counter;
    [SerializeField] private float goldPerSecond;


    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<TMP_Text>();
        gold = 0;
        goldPerSecond = 1.2f;
        

    }

    // Update is called once per frame
    void Update()
    {
        gold = updateCounter(gold, goldPerSecond);
        counter.text = (int)gold + "";
    }
}
