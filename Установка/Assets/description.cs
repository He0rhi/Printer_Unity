using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class description : MonoBehaviour
{
    // Start is called before the first frame update
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
