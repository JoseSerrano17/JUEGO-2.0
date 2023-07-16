using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComidaContador : MonoBehaviour
{

    [SerializeField] private float comida;
    [SerializeField] private TMP_Text contador;
    [SerializeField] private float comidaPorSegundo;

    // Start is called before the first frame update
    void Start()
    {
        contador = GetComponent<TMP_Text>();
        comida = 0;
        comidaPorSegundo = 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        contador.text = (int)comida + "";
        comida += comidaPorSegundo * Time.deltaTime;
    }
}
