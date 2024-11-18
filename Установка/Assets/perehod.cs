using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perehod : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim; 			      //переменная типа Animator для ссылки на анимацию
void Start(){
      anim = GetComponent<Animator>();   //инициализация контроллера анимации 
					    
}
void Update()
{
    if(Input.GetKeyDown(KeyCode.Q))   //если нажата клавиша Q
      {
       anim.SetBool("turn", true);	// переменная, отвечающая за переход имеет значение true
      }
       if(Input.GetKeyDown(KeyCode.E)) 	//если нажата клавиша E    
      {   
       anim.SetBool("turn", false);	// переменная, отвечающая за переход имеет значение false
      
      }
}

}
