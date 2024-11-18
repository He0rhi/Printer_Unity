using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    [SerializeField]
    Transform targetPos;
    [SerializeField]
    int sensitivity = 3;
    [SerializeField]
    float scrollSpeed = 10f;
    [SerializeField]
    int maxDistance = 20;
    [SerializeField]
    int minDistance = 1;
     [SerializeField]
 float movementSpeed = 5f;


      
      




    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButton(1))
        {
            float y = Input.GetAxis("Mouse X") * sensitivity;
            if (y != 0)
            {
                transform.RotateAround(targetPos.position, Vector3.up, y);
            }
        }

        // Движение камеры с клавишами WASD
        float x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        Vector3 newPosition = transform.position + new Vector3(x, 0, z);
        if (ControlDistance(Vector3.Distance(newPosition, targetPos.position)))
        {
            transform.position = newPosition;
        }

        // Приближение и удаление камеры колесом мыши
        float scrollInput = Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime;
        Vector3 scrollPosition = transform.position + transform.TransformDirection(Vector3.forward * scrollInput);
        if (ControlDistance(Vector3.Distance(scrollPosition, targetPos.position)))
        {
            transform.position = scrollPosition;
        }
    }

    bool ControlDistance(float distance)
    {
        if (distance > minDistance && distance < maxDistance) return true;
        return false;
    }
}
