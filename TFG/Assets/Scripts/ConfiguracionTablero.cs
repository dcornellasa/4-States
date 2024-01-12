using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ConfiguracionTablero : MonoBehaviour
{
    public Juego juego;

    public void configuracionInicial(string nombreEscena)
    {
        if (nombreEscena.Equals("Nivel01"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "3";
            juego.botones[1].GetComponentInChildren<Text>().text = "1";
            juego.botones[2].GetComponentInChildren<Text>().text = "1";
            juego.botones[3].GetComponentInChildren<Text>().text = "2";
            juego.botones[4].GetComponentInChildren<Text>().text = "0";
            juego.botones[5].GetComponentInChildren<Text>().text = "0";
            juego.botones[6].GetComponentInChildren<Text>().text = "2";
            juego.botones[7].GetComponentInChildren<Text>().text = "1";
            juego.botones[8].GetComponentInChildren<Text>().text = "1";

        }
        else if (nombreEscena.Equals("Nivel02"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "3";
            juego.botones[1].GetComponentInChildren<Text>().text = "3";
            juego.botones[2].GetComponentInChildren<Text>().text = "2";
            juego.botones[3].GetComponentInChildren<Text>().text = "1";
            juego.botones[4].GetComponentInChildren<Text>().text = "2";
            juego.botones[5].GetComponentInChildren<Text>().text = "1";
            juego.botones[6].GetComponentInChildren<Text>().text = "1";
            juego.botones[7].GetComponentInChildren<Text>().text = "0";
            juego.botones[8].GetComponentInChildren<Text>().text = "1";

        }
        else if (nombreEscena.Equals("Nivel03"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "3";
            juego.botones[1].GetComponentInChildren<Text>().text = "0";
            juego.botones[2].GetComponentInChildren<Text>().text = "0";
            juego.botones[3].GetComponentInChildren<Text>().text = "1";
            juego.botones[4].GetComponentInChildren<Text>().text = "3";
            juego.botones[5].GetComponentInChildren<Text>().text = "0";
            juego.botones[6].GetComponentInChildren<Text>().text = "1";
            juego.botones[7].GetComponentInChildren<Text>().text = "1";
            juego.botones[8].GetComponentInChildren<Text>().text = "3";

        }
        else if (nombreEscena.Equals("Nivel04"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "2";
            juego.botones[1].GetComponentInChildren<Text>().text = "1";
            juego.botones[2].GetComponentInChildren<Text>().text = "2";
            juego.botones[3].GetComponentInChildren<Text>().text = "1";
            juego.botones[4].GetComponentInChildren<Text>().text = "1";
            juego.botones[5].GetComponentInChildren<Text>().text = "0";
            juego.botones[6].GetComponentInChildren<Text>().text = "2";
            juego.botones[7].GetComponentInChildren<Text>().text = "1";
            juego.botones[8].GetComponentInChildren<Text>().text = "2";
        }
        else if (nombreEscena.Equals("Nivel05"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "3";
            juego.botones[1].GetComponentInChildren<Text>().text = "1";
            juego.botones[2].GetComponentInChildren<Text>().text = "2";
            juego.botones[3].GetComponentInChildren<Text>().text = "1";
            juego.botones[4].GetComponentInChildren<Text>().text = "1";
            juego.botones[5].GetComponentInChildren<Text>().text = "1";
            juego.botones[6].GetComponentInChildren<Text>().text = "1";
            juego.botones[7].GetComponentInChildren<Text>().text = "0";
            juego.botones[8].GetComponentInChildren<Text>().text = "2";
        }
        else if (nombreEscena.Equals("Nivel06"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "3";
            juego.botones[1].GetComponentInChildren<Text>().text = "2";
            juego.botones[2].GetComponentInChildren<Text>().text = "3";
            juego.botones[3].GetComponentInChildren<Text>().text = "2";
            juego.botones[4].GetComponentInChildren<Text>().text = "1";
            juego.botones[5].GetComponentInChildren<Text>().text = "2";
            juego.botones[6].GetComponentInChildren<Text>().text = "0";
            juego.botones[7].GetComponentInChildren<Text>().text = "2";
            juego.botones[8].GetComponentInChildren<Text>().text = "2";
            juego.botones[9].GetComponentInChildren<Text>().text = "0";
            juego.botones[10].GetComponentInChildren<Text>().text = "2";
            juego.botones[11].GetComponentInChildren<Text>().text = "1";
            juego.botones[12].GetComponentInChildren<Text>().text = "2";
            juego.botones[13].GetComponentInChildren<Text>().text = "3";
            juego.botones[14].GetComponentInChildren<Text>().text = "2";
            juego.botones[15].GetComponentInChildren<Text>().text = "3";
        }
        else if (nombreEscena.Equals("Nivel07"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "3";
            juego.botones[1].GetComponentInChildren<Text>().text = "3";
            juego.botones[2].GetComponentInChildren<Text>().text = "1";
            juego.botones[3].GetComponentInChildren<Text>().text = "3";
            juego.botones[4].GetComponentInChildren<Text>().text = "3";
            juego.botones[5].GetComponentInChildren<Text>().text = "0";
            juego.botones[6].GetComponentInChildren<Text>().text = "1";
            juego.botones[7].GetComponentInChildren<Text>().text = "1";
            juego.botones[8].GetComponentInChildren<Text>().text = "1";
            juego.botones[9].GetComponentInChildren<Text>().text = "1";
            juego.botones[10].GetComponentInChildren<Text>().text = "0";
            juego.botones[11].GetComponentInChildren<Text>().text = "3";
            juego.botones[12].GetComponentInChildren<Text>().text = "1";
            juego.botones[13].GetComponentInChildren<Text>().text = "0";
            juego.botones[14].GetComponentInChildren<Text>().text = "2";
            juego.botones[15].GetComponentInChildren<Text>().text = "3";
        }
        else if (nombreEscena.Equals("Nivel08"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "2";
            juego.botones[1].GetComponentInChildren<Text>().text = "0";
            juego.botones[2].GetComponentInChildren<Text>().text = "2";
            juego.botones[3].GetComponentInChildren<Text>().text = "2";
            juego.botones[4].GetComponentInChildren<Text>().text = "1";
            juego.botones[5].GetComponentInChildren<Text>().text = "1";
            juego.botones[6].GetComponentInChildren<Text>().text = "0";
            juego.botones[7].GetComponentInChildren<Text>().text = "3";
            juego.botones[8].GetComponentInChildren<Text>().text = "2";
            juego.botones[9].GetComponentInChildren<Text>().text = "0";
            juego.botones[10].GetComponentInChildren<Text>().text = "0";
            juego.botones[11].GetComponentInChildren<Text>().text = "2";
            juego.botones[12].GetComponentInChildren<Text>().text = "3";
            juego.botones[13].GetComponentInChildren<Text>().text = "1";
            juego.botones[14].GetComponentInChildren<Text>().text = "1";
            juego.botones[15].GetComponentInChildren<Text>().text = "2";
        }
        else if (nombreEscena.Equals("Nivel09"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "3";
            juego.botones[1].GetComponentInChildren<Text>().text = "1";
            juego.botones[2].GetComponentInChildren<Text>().text = "1";
            juego.botones[3].GetComponentInChildren<Text>().text = "2";
            juego.botones[4].GetComponentInChildren<Text>().text = "2";
            juego.botones[5].GetComponentInChildren<Text>().text = "0";
            juego.botones[6].GetComponentInChildren<Text>().text = "0";
            juego.botones[7].GetComponentInChildren<Text>().text = "2";
            juego.botones[8].GetComponentInChildren<Text>().text = "1";
            juego.botones[9].GetComponentInChildren<Text>().text = "1";
            juego.botones[10].GetComponentInChildren<Text>().text = "0";
            juego.botones[11].GetComponentInChildren<Text>().text = "2";
            juego.botones[12].GetComponentInChildren<Text>().text = "2";
            juego.botones[13].GetComponentInChildren<Text>().text = "0";
            juego.botones[14].GetComponentInChildren<Text>().text = "1";
            juego.botones[15].GetComponentInChildren<Text>().text = "1";
        }
        else if (nombreEscena.Equals("Nivel10"))
        {
            juego.botones[0].GetComponentInChildren<Text>().text = "2";
            juego.botones[1].GetComponentInChildren<Text>().text = "1";
            juego.botones[2].GetComponentInChildren<Text>().text = "1";
            juego.botones[3].GetComponentInChildren<Text>().text = "2";
            juego.botones[4].GetComponentInChildren<Text>().text = "1";
            juego.botones[5].GetComponentInChildren<Text>().text = "0";
            juego.botones[6].GetComponentInChildren<Text>().text = "0";
            juego.botones[7].GetComponentInChildren<Text>().text = "0";
            juego.botones[8].GetComponentInChildren<Text>().text = "2";
            juego.botones[9].GetComponentInChildren<Text>().text = "1";
            juego.botones[10].GetComponentInChildren<Text>().text = "0";
            juego.botones[11].GetComponentInChildren<Text>().text = "1";
            juego.botones[12].GetComponentInChildren<Text>().text = "1";
            juego.botones[13].GetComponentInChildren<Text>().text = "1";
            juego.botones[14].GetComponentInChildren<Text>().text = "2";
            juego.botones[15].GetComponentInChildren<Text>().text = "1";
        }
    }

   
}
