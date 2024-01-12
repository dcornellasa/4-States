using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AudioClick : MonoBehaviour
{
    public AudioSource Source { get { return GetComponent<AudioSource>(); } }
    public Button Boton { get { return GetComponent<Button>(); } }
    public AudioClip clip;





    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        Boton.onClick.AddListener(PlayAudio);
    }

    void PlayAudio()
    {
        
        Source.PlayOneShot(clip);
        DontDestroyOnLoad(clip);
    }

}
