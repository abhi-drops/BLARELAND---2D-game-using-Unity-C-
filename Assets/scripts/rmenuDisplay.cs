using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rmenuDisplay : MonoBehaviour
{
   public GameObject gVar;

   void Update()
    {
        gameObject.GetComponent<Canvas>().enabled = globalVar.RMenu;
    }

}
