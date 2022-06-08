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
    public Image[] ColorCats;
    public Color PickColor;
    public AudioSource AS;
    public float VolumValue;

    bool blue = false;
    bool red = false;
    bool green = false;

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
        Canvas[1].SetActive(true);
        Canvas[0].SetActive(false);

        CatsImg[0].SetActive(false);
        CatsImg[1].SetActive(false);
        CatsImg[2].SetActive(false);
        CatsImg[3].SetActive(false);
        CatsImg[4].SetActive(false);

        
    }

    public void Windows()
    {
        float Cats = CatsNum.value;

        for (int i = 0; i <= Cats; i++)
        {
            CatsImg[i].SetActive(true);

            if (green)
            {
                ColorCats[i].color = Color.green;
            }
            else if(blue)
            {
                ColorCats[i].color = Color.blue;
            }else if(red)
            {
                ColorCats[i].color = Color.red;
            }
        }
        

        Canvas[0].SetActive(true);
        Canvas[1].SetActive(false);
    }

    public void Gr()
    {
        green = true;
        blue = false;
        red = false;
    }

    public void Bl()
    {
        green = false;
        blue = true;
        red = false;
    }
    public void Re()
    {
        green = false;
        blue = false;
        red = true;
    }
}
