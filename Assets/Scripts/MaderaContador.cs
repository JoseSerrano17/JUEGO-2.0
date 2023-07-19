using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorMadera : Contador
{
    [SerializeField] private float wood;
    [SerializeField] private TMP_Text counter;
    [SerializeField] private float woodPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<TMP_Text>();
        wood = 0;
        woodPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        wood = updateCounter(wood, woodPerSecond);
        counter.text = (int)wood + "";
    }
}
