using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vvodmetall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Open();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Close(){
    gameObject.SetActive(false);
   }
   public void Open(){
    gameObject.SetActive(true);
   }
}
