using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                 

public class Elements : MonoBehaviour
{
[SerializeField] 
   private Text message;  // объявить переменную и связать ее с на текстовым окном
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void OnPointer () {  
message.text = "Розетку требуется включить для подачи напряжения";  
} 

    // Update is called once per frame
    void Update()
    {
        
    }
}
