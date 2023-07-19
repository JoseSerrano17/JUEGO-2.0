using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComidaContador : Contador
{
    [SerializeField] private float food;
    [SerializeField] private TMP_Text counter;
    [SerializeField] private float foodPerSecond;

    void Start()
    {
        counter = GetComponent<TMP_Text>();
        food = 0;
        foodPerSecond = 0.8f;
    }

    void Update()
    {
        food = updateCounter(food, foodPerSecond);
        counter.text = (int)food + "";
    }
}
