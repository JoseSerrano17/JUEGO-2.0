using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorMadera : Contador
{
    void Start()
    {
        base.startGeneral();
        resPerSecond = 0.8f;
    }

    void Update()
    {
        resource = updateCounter(resource, resPerSecond);
        counterText.text = (int)resource + "";
    }
}
