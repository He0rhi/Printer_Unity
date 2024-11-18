using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state : MonoBehaviour
{
    void Start()
    {
        Close();
    }

    // Update is called once per frame
   public void Open(){
    gameObject.SetActive(true);
   }
   public void Close(){
    gameObject.SetActive(false);
   }
}
