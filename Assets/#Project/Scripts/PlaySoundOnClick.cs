using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
   public AudioSource source;       // to be able to click and drag audio 

    void OnMouseDown()
    {
        source.Play();
    }


}
