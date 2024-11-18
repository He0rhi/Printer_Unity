using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rozetkaelememt : MonoBehaviour
{

   public GameObject втулка1;
    public GameObject втулка2;
    public GameObject корона;
    public GameObject провод;
    public GameObject крепеж;
    private float totalMovementTime = 5f; // Время, за которое объект должен переместиться
    private float currentMovementTime = 0f; // Время, прошедшее с начала движения
    private Vector3 mOffset;
    private float mZCoord;
    private GameObject selectedObject;

  

  void OnMouseDown()
{

 MoveObjectZ(втулка1);
        MoveObjectZ(втулка2);
        MoveObjectZ(провод);
       MoveObjectZ(крепеж);
       MoveObjectZ(корона);
}
 void MoveObjectZ(GameObject obj)
    {
        if(корона.transform.position.z <= -105){
 Vector3 startPosition = obj.transform.position;
        Vector3 endPosition = startPosition;
        endPosition.z += 4.5f;

        while (Vector3.Distance(obj.transform.position, endPosition) > 0)
        {
            currentMovementTime += Time.deltaTime;
            obj.transform.position = Vector3.Lerp(startPosition, endPosition, currentMovementTime / totalMovementTime);
        }
        }
        else{
Vector3 startPosition = obj.transform.position;
        Vector3 endPosition = startPosition;
        endPosition.z -= 4.5f;

        while (Vector3.Distance(obj.transform.position, endPosition) > 0)
        {
            currentMovementTime += Time.deltaTime;
            obj.transform.position = Vector3.Lerp(startPosition, endPosition, currentMovementTime / totalMovementTime);

        }
       }
    }
    public Color col = new Color();

public void Start(){
       col = GetComponent<Renderer>().material.color;
      
     
}
    // Start is called before the first frame update
       public void ChangCol()
    {
        GetComponent<Renderer>().material.color = new Color (1, 0, 0);   
    }

    public void ChangCol1()
    {
        GetComponent<Renderer>().material.color = col;   
    }



 
    
}
