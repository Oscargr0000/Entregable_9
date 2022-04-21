using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject Inicio;
    public GameObject Opciones;

    // Start is called before the first frame update
    void Start()
    {
        Inicio.SetActive(true);
        Opciones.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Options()
    {
        Opciones.SetActive(true);
        Inicio.SetActive(false);

    }

    public void Windows()
    {
        Inicio.SetActive(true);
        Opciones.SetActive(false);
        
    }
}
