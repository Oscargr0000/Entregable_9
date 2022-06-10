using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject[] Canvas;

    public Slider SliderVolum;
    public Slider CatsNum;
    public GameObject[] CatsImg;

    public Image[] ColorsBotton;
    private Color COLOR;
    public Image[] ColorCats;
    public Color PickColor;
    public AudioSource AS;
    public float VolumValue;

    public GameObject[] Tootips;


    // Start is called before the first frame update
    void Start()
    {
        Canvas[0].SetActive(true);
        Canvas[1].SetActive(false);

        CatsImg[0].SetActive(false);
        CatsImg[1].SetActive(false);
        CatsImg[2].SetActive(false);
        CatsImg[3].SetActive(false);
        CatsImg[4].SetActive(false);

        CatsImg[0].GetComponent<Image>();

        SliderVolum.value = 0.5f;
        AS.volume = SliderVolum.value;
        PickColor.a = 1;

       
    }


    public void ChangeSlider(float Valor)
    {
        SliderVolum.value = Valor;
        AS.volume = SliderVolum.value;
    }

    public void Options()
    {
        //Activa el canvas de opciones y desactiva los gatos para que estos se actualicen luego
        Canvas[1].SetActive(true);
        Canvas[0].SetActive(false);

        CatsImg[0].SetActive(false);
        CatsImg[1].SetActive(false);
        CatsImg[2].SetActive(false);
        CatsImg[3].SetActive(false);
        CatsImg[4].SetActive(false);

        Tootips[0].SetActive(false);
        Tootips[1].SetActive(false);
        Tootips[2].SetActive(false);
    }

    public void Windows()
    {
        //Cuando se le da al boton regtreso a windows, coge el valor del slider y activa
        //los gatos de la array y tambien deberia de darle el color seleccionado
        float Cats = CatsNum.value;

        for (int i = 0; i <= Cats; i++)
        {
            CatsImg[i].SetActive(true);
            //ColorCats[i].color = COLOR; //NO FUNCIONA BIEN Y NO SE VEN LOS GATOS
        }
        
        //Cambiar de canvas
        Canvas[0].SetActive(true);
        Canvas[1].SetActive(false);
    }


    //Botones de seleccion de color
    public void Gr()
    {
        COLOR = ColorsBotton[0].color;
    }

    public void Bl()
    {
        COLOR = ColorsBotton[1].color;
    }
    public void Re()
    {
        COLOR = ColorsBotton[2].color;
    }
}
