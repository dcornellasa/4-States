using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Juego : MonoBehaviour
{

    public Button[] botones;
    bool hasGanado;


    public Button startButton;
    public Button resetButton;
    public Text winAnnouncement;


    // Start is called before the first frame update
    void Start()
    {

        InhabilitarTablero();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startJuego()
    {

        botones[0].GetComponent<Image>().color = Color.red;
        botones[1].GetComponent<Image>().color = Color.red;
        botones[2].GetComponent<Image>().color = Color.red;
        botones[3].GetComponent<Image>().color = Color.red;
        botones[6].GetComponent<Image>().color = Color.red;
        botones[7].GetComponent<Image>().color = Color.red;
        botones[8].GetComponent<Image>().color = Color.red;

        HabilitarTablero();
        startButton.interactable = false;

    }

    public void resetJuego()
    {
        resetTablero();
        InhabilitarTablero();
        winAnnouncement.text = "";
        startButton.interactable = true;

    }

    public void ClickBoton(Button boton)
    {

        string targetButton = boton.name;
        switch (targetButton)
        {

            case "0":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[1].GetComponent<Image>());
                cambiarColor(botones[3].GetComponent<Image>());

                break;
            case "1":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[0].GetComponent<Image>());
                cambiarColor(botones[2].GetComponent<Image>());
                cambiarColor(botones[4].GetComponent<Image>());
                break;
            case "2":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[1].GetComponent<Image>());
                cambiarColor(botones[5].GetComponent<Image>());
                break;
            case "3":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[0].GetComponent<Image>());
                cambiarColor(botones[4].GetComponent<Image>());
                cambiarColor(botones[6].GetComponent<Image>());

                break;
            case "4":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[1].GetComponent<Image>());
                cambiarColor(botones[3].GetComponent<Image>());
                cambiarColor(botones[5].GetComponent<Image>());
                cambiarColor(botones[7].GetComponent<Image>());

                break;
            case "5":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[2].GetComponent<Image>());
                cambiarColor(botones[4].GetComponent<Image>());
                cambiarColor(botones[8].GetComponent<Image>());

                break;
            case "6":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[3].GetComponent<Image>());
                cambiarColor(botones[7].GetComponent<Image>());

                break;
            case "7":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[4].GetComponent<Image>());
                cambiarColor(botones[6].GetComponent<Image>());
                cambiarColor(botones[8].GetComponent<Image>());

                break;
            case "8":
                cambiarColor(boton.GetComponent<Image>());
                cambiarColor(botones[5].GetComponent<Image>());
                cambiarColor(botones[7].GetComponent<Image>());
                break;
            default:
                break;
        }

        checkForWin();
    }

    private void cambiarColor(Image image)
    {
        if (image.color == Color.red)
        {
            image.color = Color.white;
        }
        else
        {
            image.color = Color.red;
        }
    }

    private void checkForWin()
    {
        hasGanado = true;
        foreach (Button boton in botones)
        {
            if (boton.GetComponent<Image>().color == Color.red)
            {
                hasGanado = false;
            }
        }
        if (hasGanado == true)
        {
            Debug.Log("¡Victoria!");
            winAnnouncement.text = "¡HAS GANADO!";
        }
    }

    private void InhabilitarTablero()
    {
        foreach (Button boton in botones)
        {
            boton.interactable = false;
        }
    }

    private void HabilitarTablero()
    {
        foreach (Button boton in botones)
        {
            boton.interactable = true;
        }
    }

    private void resetTablero()
    {
        foreach (Button boton in botones)
        {
            boton.GetComponent<Image>().color = Color.white;
        }
    }
}
