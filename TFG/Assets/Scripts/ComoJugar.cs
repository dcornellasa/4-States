using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComoJugar : MonoBehaviour
{
    public void Volver()
    {
        SceneManager.LoadScene("Portada");
    }
}
