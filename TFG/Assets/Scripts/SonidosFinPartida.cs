using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosFinPartida : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip completado;
    public AudioClip gameOver;

    public void SonidoGameOver()
    {
        ReproduceSonido(gameOver);
    }

    public void SonidoCompletado()
    {
        ReproduceSonido(completado);
    }

    void ReproduceSonido(AudioClip sonido)
    {
        audioSource.clip = sonido;
        audioSource.Play();
    }
}
