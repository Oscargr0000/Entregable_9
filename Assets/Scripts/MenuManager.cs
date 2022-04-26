using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public GameObject Inicio;
    public GameObject Opciones;
    public GameObject WindowsWP;
    public GameObject CatsWP;
    public GameObject MoreCatsWP;

    public GameObject ToggleCats;

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

    public void WindowsXpWP()
    {
        WindowsWP.SetActive(true);
        CatsWP.SetActive(false);
        MoreCatsWP.SetActive(false);
    }

    public void Cats()
    {
        WindowsWP.SetActive(false);
        CatsWP.SetActive(true);
        MoreCatsWP.SetActive(false);
    }

    public void MoreCats()
    {
        WindowsWP.SetActive(false);
        CatsWP.SetActive(false);
        MoreCatsWP.SetActive(true);
    }

    public void Toggle(bool tog)
    {
        print(tog);
    }
}
