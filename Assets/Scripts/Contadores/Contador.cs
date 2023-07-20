using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    protected TMP_Text counterText;
    [SerializeField] protected float resource;
    [SerializeField] protected float resPerSecond;

    protected void startGeneral()
    {
        counterText = GetComponent<TMP_Text>();
        resource = 0;
    }

    void Update() // No entra
    {
        print("Hola");
        updateCounter(resource, resPerSecond);
        counterText.text = (int)resource + "";
    }

    protected float updateCounter(float resourceAux, float resPerSecondAux)
    {
        resourceAux += resPerSecondAux * Time.deltaTime;
        return resourceAux;
    }

    public void restarContadores(float coste)
    {
        resource -= coste;
    }

    public float getResource()
    {
        return resource;
    }

    public float getResourcePerSecond()
    {
        return resPerSecond;
    }
}
