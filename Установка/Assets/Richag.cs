using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Richag : MonoBehaviour
{
      public double  metall;

 public GameObject рычаг;
    private Quaternion startRotation;
    private Quaternion endRotation;
    private float rotationTime = 2.0f; // Время вращения в секундах
    private float currentRotationTime = 0.0f; // Текущее время вращения
    public GameObject стрелкаВатт;
    public TextMesh значениеНапряжения;
   private Quaternion targetRotation;
public float speed = 2.0f; // скорость поворота
private bool isRotating = false;
private Quaternion initialRotation;
      public TextMesh внешняятемп;

       public TextMesh внутренняятемп;

[SerializeField]
    InputField InputVatt;
     [SerializeField]
    InputField InputMetall;

    // Start is called before the first frame update
  void Update()
{
    if (isRotating)
    {
        стрелкаВатт.transform.rotation = Quaternion.Lerp(стрелкаВатт.transform.rotation, targetRotation, speed * Time.deltaTime);
        if (Quaternion.Angle(стрелкаВатт.transform.rotation, targetRotation) < 0.01f)
        {
            isRotating = false;
        }
    }
}
void Start(){
        initialRotation = стрелкаВатт.transform.rotation;

}
 void OnMouseDown(){
    if(Convert.ToInt32( рычаг.transform.eulerAngles.z) <118 ){
     if(Convert.ToInt32( InputVatt.text) >=30 && Convert.ToInt32( InputVatt.text) <=40 ){
     startRotation = рычаг.transform.rotation;

        // Вычисление конечного вращения
        endRotation = Quaternion.Euler(рычаг.transform.eulerAngles.x , рычаг.transform.eulerAngles.y, рычаг.transform.eulerAngles.z  + 90);

        // Запуск корутины для плавного вращения
        StartCoroutine(Rotate());
        

 if(InputMetall.text.ToString()=="медь"){
metall = 397;
    }
    else if(InputMetall.text.ToString() == "керамзитобетон"){
      metall=24;
    }
    else if(InputMetall.text.ToString() == "серебро"){
      metall=428;
    }else if(InputMetall.text.ToString() == "пеностекло"){
      metall=26;
    }
    else if(InputMetall.text.ToString() == "свинец"){
      metall=40;
    }else if(InputMetall.text.ToString() == "пенобетон"){
      metall=23;
    }
    else{
        InputMetall.text = "свинец";
         metall=40;
    }
  

    внутренняятемп.text=((((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))))/3 ).ToString()).Substring(0,5);
внешняятемп.text = ((( ((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3 ).ToString()).Substring(0,5) ;
значениеНапряжения.text = InputVatt.text;

if( InputVatt.text=="30"){
    targetRotation = Quaternion.Euler(-23, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;
    Debug.Log("УГОЛ -23");
}
else if(InputVatt.text=="31"){
    targetRotation = Quaternion.Euler(-23, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
               isRotating = true;


}
else if(InputVatt.text=="32"){
    targetRotation = Quaternion.Euler(-22, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else if(InputVatt.text.ToString()=="33"){
    targetRotation = Quaternion.Euler(-22, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else if(InputVatt.text=="34"){
    targetRotation = Quaternion.Euler(-21, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else if(InputVatt.text=="35"){
    targetRotation = Quaternion.Euler(-20, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else if(InputVatt.text=="36"){
    targetRotation = Quaternion.Euler(-19, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else if(InputVatt.text=="37"){
    targetRotation = Quaternion.Euler(-18, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else if(InputVatt.text=="38"){
    targetRotation = Quaternion.Euler(-18, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else if(InputVatt.text=="39"){
    targetRotation = Quaternion.Euler(-17, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
else{
    targetRotation = Quaternion.Euler(-16, стрелкаВатт.transform.eulerAngles.y, стрелкаВатт.transform.eulerAngles.z);
        isRotating = true;

}
}
else{

    внутренняятемп.text = "00.00";
     внешняятемп.text = "00.00";
     значениеНапряжения.text = "00"; 
}}
else{  
    Debug.Log("Изменение температур");
  внутренняятемп.text = "00.00";
     внешняятемп.text = "00.00";
     значениеНапряжения.text = "00";
       // Вычисление конечного вращения
      
        startRotation = рычаг.transform.rotation;
         Debug.Log("вычисление startRotation ");
  
        // Вычисление конечного вращения
        endRotation = Quaternion.Euler(рычаг.transform.eulerAngles.x , рычаг.transform.eulerAngles.y, рычаг.transform.eulerAngles.z  - 90);
         Debug.Log("вычисление endRotation ");

        // Запуск корутины для плавного вращения
        StartCoroutine(Rotate());
      Debug.Log("StartCoroutine");
   targetRotation = initialRotation;
        isRotating = true;
      
}

}

public void Offs(){
   
}
IEnumerator Rotate()
    {
          Debug.Log("до while");
           currentRotationTime = 0.0f; // Текущее время вращения
        while (currentRotationTime <= rotationTime)
        {
            // Плавное вращение объекта
            рычаг.transform.rotation = Quaternion.Lerp(startRotation, endRotation, currentRotationTime / rotationTime);
            currentRotationTime += Time.deltaTime;
            yield return null;
         
        }
         Debug.Log("после while");
    }
    // Update is called once per frame
   
}
