using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComidaContador : Contador
{

    [SerializeField] private float food;
    [SerializeField] private TMP_Text counter;
    [SerializeField] private float foodPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<TMP_Text>();
        food = 0;
        foodPerSecond = 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        food = updateCounter(food, foodPerSecond);
        counter.text = (int)food + "";
    }
}
