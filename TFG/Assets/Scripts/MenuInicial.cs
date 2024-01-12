using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuInicial : MonoBehaviour
{

    public Button BotonJugar;
    public Button BotonSalir;
    public Button BotonComoJugar;




    public void Jugar()
    {
        SceneManager.LoadScene("MenuNiveles");
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }

    public void ComoJugar()
    {
        SceneManager.LoadScene("ComoJugar");
    }
}
