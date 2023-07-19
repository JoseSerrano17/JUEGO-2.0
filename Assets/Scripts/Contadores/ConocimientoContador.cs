using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConocimientoContador : Contador
{
    [SerializeField] private float knowledge;
    [SerializeField] private TMP_Text counter;
    [SerializeField] private float knowledgePerSecond;

    void Start()
    {
        counter = GetComponent<TMP_Text>();
        knowledge = 0;
        knowledgePerSecond = 0.4f;
    }

    void Update()
    {
        knowledge = updateCounter(knowledge, knowledgePerSecond);
        counter.text = (int)knowledge + "";
    }
}
