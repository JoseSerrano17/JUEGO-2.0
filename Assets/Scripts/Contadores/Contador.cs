using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    protected TMP_Text counterText;
    protected float resource;
    protected float resPerSecond;

    void Start()
    {
        counterText = GetComponent<TMP_Text>();
        resource = 0f;
        resPerSecond = 0f;
    }

    protected float updateCounter(float resourceAux, float resPerSecondAux)
    {
        resourceAux += resPerSecondAux * Time.deltaTime;
        return resourceAux;
    }

    protected TMP_Text getCounterText()
    {
        return counterText;
    }

    protected void setCounterText(TMP_Text text)
    {
        this.counterText = text;
    }

    protected float getResource()
    {
        return resource;
    }

    protected void setResource(float resource)
    {
        this.resource = resource;
    }

    protected float getResourcePerSecond()
    {
        return resPerSecond;
    }

    protected void setResourcePerSecond(float resourcePerSecond)
    {
        this.resPerSecond = resourcePerSecond;
    }
}
