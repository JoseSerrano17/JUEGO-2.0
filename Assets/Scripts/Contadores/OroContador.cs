using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorOro : Contador
{

    void Start()
    {
        base.startGeneral();
        resPerSecond = 2.0f;
    }

    void Update()
    {
        resource = updateCounter(resource, resPerSecond);
        counterText.text = (int)resource + "";
    }
}
