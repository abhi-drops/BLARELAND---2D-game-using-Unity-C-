using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute_button : MonoBehaviour
{
   public void muteOrUnmute()
   {
        if(AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
        }
        else if(AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        }
   }
}

