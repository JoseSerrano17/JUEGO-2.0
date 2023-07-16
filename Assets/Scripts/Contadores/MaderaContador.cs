using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorMadera : MonoBehaviour
{
    [SerializeField] private float madera;
    [SerializeField] private TMP_Text contador;
    [SerializeField] private float maderaPorSegundo;
    // Start is called before the first frame update
    void Start()
    {
        contador = GetComponent<TMP_Text>();
        madera = 0;
        maderaPorSegundo = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        contador.text = (int)madera + "";
        madera += maderaPorSegundo * Time.deltaTime;
    }
}
