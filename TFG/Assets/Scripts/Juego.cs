using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class Juego : MonoBehaviour
{

    public Button[] botones;
    public bool hasGanado;


    public Button startButton;
    public Button resetButton;
    public Button siguienteButton;
    public Button nivelesButton;
    public Text mensajeResultado;
    public SonidosFinPartida sonidosFinPartida;
    public ConfiguracionTablero configuracionTablero;
    public CambiarEstadoBotones cambiarEstadoBotones;


    void Start()
    {

        InhabilitarTablero();
        InhabilitarSiguiente();

    }

    public void startJuego()
    {
        Scene escenaActual;
        string nombreEscena;

        escenaActual = SceneManager.GetActiveScene();
        nombreEscena = escenaActual.name;

        //configuracionesInciales(nombreEscena);
        configuracionTablero.configuracionInicial(nombreEscena);



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
        cambiarEstadoBotones.cambiarEstado(boton);
        ComprobarVictoria();

    }

    public void SiguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        InhabilitarSiguiente();
    }

    public void volverANiveles()
    {
        SceneManager.LoadScene("MenuNiveles");
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
            sonidosFinPartida.SonidoCompletado();
            mensajeResultado.text = "¡HAS GANADO!";
            HabilitarSiguiente();


            foreach (Button boton in botones)
            {

                boton.GetComponent<Image>().color = Color.green;
            }
            InhabilitarTablero();
        }
    }

    public void InhabilitarTablero()
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

    private void InhabilitarSiguiente()
    {
        siguienteButton.interactable = false;
    }

    private void HabilitarSiguiente()
    {
        siguienteButton.interactable = true;
        siguienteButton.GetComponent<Image>().color = new Color(24 / 255f, 106 / 255f, 23 / 255f);
    }



    private void resetTablero()
    {
        foreach (Button boton in botones)
        {
            boton.GetComponent<Image>().color = Color.white;
        }
    }
}

