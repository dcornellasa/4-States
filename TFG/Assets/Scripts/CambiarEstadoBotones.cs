
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class CambiarEstadoBotones : MonoBehaviour
{
    public Juego juego;

    public void cambiarEstado(Button boton)
    {
        string targetButton = boton.name;

        if (juego.botones.Length == 9)
        {
            switch (targetButton)
            {

                case "0":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[1].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[3].GetComponentInChildren<Text>());

                    break;
                case "1":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[0].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[2].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[4].GetComponentInChildren<Text>());
                    break;
                case "2":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[1].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[5].GetComponentInChildren<Text>());

                    break;
                case "3":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[0].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[4].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[6].GetComponentInChildren<Text>());
                    break;
                case "4":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[1].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[3].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[5].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[7].GetComponentInChildren<Text>());

                    break;
                case "5":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[2].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[4].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[8].GetComponentInChildren<Text>());

                    break;
                case "6":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[3].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[7].GetComponentInChildren<Text>());

                    break;
                case "7":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[4].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[6].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[8].GetComponentInChildren<Text>());

                    break;
                case "8":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[5].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[7].GetComponentInChildren<Text>());
                    break;
                default:
                    break;
            }

        }
        else if (juego.botones.Length == 16)
        {
            switch (targetButton)
            {
                case "0":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[1].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[4].GetComponentInChildren<Text>());

                    break;
                case "1":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[0].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[2].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[5].GetComponentInChildren<Text>());
                    break;
                case "2":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[1].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[3].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[6].GetComponentInChildren<Text>());
                    break;
                case "3":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[2].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[7].GetComponentInChildren<Text>());
                    break;
                case "4":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[0].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[5].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[8].GetComponentInChildren<Text>());
                    break;
                case "5":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[1].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[4].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[6].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[9].GetComponentInChildren<Text>());
                    break;
                case "6":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[2].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[5].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[7].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[10].GetComponentInChildren<Text>());
                    break;
                case "7":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[3].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[6].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[11].GetComponentInChildren<Text>());
                    break;
                case "8":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[4].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[9].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[12].GetComponentInChildren<Text>());
                    break;
                case "9":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[5].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[8].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[10].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[13].GetComponentInChildren<Text>());
                    break;
                case "10":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[6].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[9].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[11].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[14].GetComponentInChildren<Text>());
                    break;
                case "11":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[7].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[10].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[15].GetComponentInChildren<Text>());
                    break;
                case "12":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[8].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[13].GetComponentInChildren<Text>());
                    break;
                case "13":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[9].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[12].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[14].GetComponentInChildren<Text>());
                    break;
                case "14":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[10].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[13].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[15].GetComponentInChildren<Text>());
                    break;
                case "15":
                    cambiarNum(boton.GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[11].GetComponentInChildren<Text>());
                    cambiarNum(juego.botones[14].GetComponentInChildren<Text>());
                    break;
                default:
                    break;
            }
        }


        
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
        foreach (Button boton in juego.botones)
        {

            boton.GetComponent<Image>().color = Color.red;
        }

        Debug.Log("¡Perdedor!");
        juego.sonidosFinPartida.SonidoGameOver();
        juego.mensajeResultado.text = "Has perdido...";
        juego.InhabilitarTablero();
    }


}
