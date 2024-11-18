using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public AudioClip clickAudio; // звуковой клип щелчка
    public AudioSource audioSource; // источник звука

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     
    }
       public void PlaySound () 
    {
        audioSource.clip = clickAudio; // устанавливаем звуковой клип
        audioSource.Play(); // воспроизводим звук
        Debug.Log("ЗВук произведен");
    }
}
