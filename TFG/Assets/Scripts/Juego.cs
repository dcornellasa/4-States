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
    public Text mensajeResultado;


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

        botones[0].GetComponentInChildren<Text>().text = "3";
        botones[1].GetComponentInChildren<Text>().text = "1";
        botones[2].GetComponentInChildren<Text>().text = "1";
        botones[3].GetComponentInChildren<Text>().text = "2";
        botones[4].GetComponentInChildren<Text>().text = "0";
        botones[5].GetComponentInChildren<Text>().text = "0";
        botones[6].GetComponentInChildren<Text>().text = "2";
        botones[7].GetComponentInChildren<Text>().text = "1";
        botones[8].GetComponentInChildren<Text>().text = "1";

        HabilitarTablero();
        startButton.interactable = false;

    }

    public void resetJuego()
    {
        resetTablero();
        InhabilitarTablero();
        mensajeResultado.text = "";
        startButton.interactable = true;

    }

    public void ClickBoton(Button boton)
    {

        string targetButton = boton.name;
        switch (targetButton)
        {

            case "0":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[1].GetComponentInChildren<Text>());
                cambiarNum(botones[3].GetComponentInChildren<Text>());

                break;
            case "1":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[0].GetComponentInChildren<Text>());
                cambiarNum(botones[2].GetComponentInChildren<Text>());
                cambiarNum(botones[4].GetComponentInChildren<Text>());
                break;
            case "2":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[1].GetComponentInChildren<Text>());
                cambiarNum(botones[5].GetComponentInChildren<Text>());

                break;
            case "3":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[0].GetComponentInChildren<Text>());
                cambiarNum(botones[4].GetComponentInChildren<Text>());
                cambiarNum(botones[6].GetComponentInChildren<Text>());
                break;
            case "4":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[1].GetComponentInChildren<Text>());
                cambiarNum(botones[3].GetComponentInChildren<Text>());
                cambiarNum(botones[5].GetComponentInChildren<Text>());
                cambiarNum(botones[7].GetComponentInChildren<Text>());

                break;
            case "5":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[2].GetComponentInChildren<Text>());
                cambiarNum(botones[4].GetComponentInChildren<Text>());
                cambiarNum(botones[8].GetComponentInChildren<Text>());

                break;
            case "6":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[3].GetComponentInChildren<Text>());
                cambiarNum(botones[7].GetComponentInChildren<Text>());

                break;
            case "7":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[4].GetComponentInChildren<Text>());
                cambiarNum(botones[6].GetComponentInChildren<Text>());
                cambiarNum(botones[8].GetComponentInChildren<Text>());

                break;
            case "8":
                cambiarNum(boton.GetComponentInChildren<Text>());
                cambiarNum(botones[5].GetComponentInChildren<Text>());
                cambiarNum(botones[7].GetComponentInChildren<Text>());
                break;
            default:
                break;
        }

        ComprobarVictoria();
    }

    private void cambiarNum(Text text)
    {
        if (text.text == "0")
        {
            text.text = "1";
        }
        else if (text.text == "1")
        {
            text.text = "2";
        }
        else if (text.text == "2")
        {
            text.text = "3";
        }
        else if (text.text == "3")
        {
            text.text = "X";
            HasPerdido();
        }
    }
    private void HasPerdido()
    {
        foreach (Button boton in botones)
        {

            boton.GetComponent<Image>().color = Color.red;
        }

        Debug.Log("¡Perdedor!");
        mensajeResultado.text = "Has perdido...";
        InhabilitarTablero();
    }

    private void ComprobarVictoria()
    {
        hasGanado = true;
        foreach (Button boton in botones)
        {
            if (boton.GetComponentInChildren<Text>().text != "3")
            {
                hasGanado = false;
            }
        }
        if (hasGanado == true)
        {
            Debug.Log("¡Victoria!");
            mensajeResultado.text = "¡HAS GANADO!";

            foreach (Button boton in botones)
            {

                boton.GetComponent<Image>().color = Color.green;
            }
            InhabilitarTablero();
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
