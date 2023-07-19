using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConocimientoContador : Contador
{

    [SerializeField] private float knowledge;
    [SerializeField] private TMP_Text counter;
    [SerializeField] private float knowledgePerSecond;

    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<TMP_Text>();
        knowledge = 0;
        knowledgePerSecond = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        knowledge = updateCounter(knowledge, knowledgePerSecond);
        counter.text = (int)knowledge + "";
    }
}
