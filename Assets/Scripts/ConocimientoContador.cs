using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConocimientoContador : MonoBehaviour
{

    [SerializeField] private float conocimiento;
    [SerializeField] private TMP_Text contador;
    [SerializeField] private float conocimientoPorSegundo;

    // Start is called before the first frame update
    void Start()
    {
        contador = GetComponent<TMP_Text>();
        conocimiento = 0;
        conocimientoPorSegundo = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        contador.text = (int)conocimiento + "";
        conocimiento += conocimientoPorSegundo * Time.deltaTime;
    }
}
