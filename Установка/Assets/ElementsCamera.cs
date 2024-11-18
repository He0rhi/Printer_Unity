using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsCamera : MonoBehaviour
{
      bool move = false;
        float speed = 0.01f;
        float offset = 0;
        Vector3 startPosition;
        Vector3 needPosition;
        Quaternion startRotation;
        Quaternion needRotaton;

       public void MoveRozetka()
        {  move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-439, 36, -103);
            needRotaton = Quaternion.AngleAxis(200, new Vector3(0,1,0));   Update();       }
            public void MoveSwitch()
        {  move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-438, 36, -109);
            needRotaton = Quaternion.AngleAxis(-90, new Vector3(0,1,0));   Update();       }
            public void MoveValikKnob()
        {  move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-436, 37, -114);
            needRotaton = Quaternion.AngleAxis(-52, new Vector3(0,1,0));   Update();       }
            public void MoveRyshag()
        {  move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-439, 39, -112);
            needRotaton = Quaternion.AngleAxis(-47, new Vector3(0,1,0));   Update();       }
            public void MoveGolovka()
        {  move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-447, 39, -114);
            needRotaton = Quaternion.AngleAxis(57, new Vector3(1,0,0));   Update();       }
public void MoveCover()
        {  move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-445, 45, -117);
            needRotaton = Quaternion.AngleAxis(57, new Vector3(1,0,0));   Update();       }
        public void MoveComeBack()
        {  move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-443, 45, -132);
            needRotaton = Quaternion.AngleAxis(0, new Vector3(0,1,0));   Update();     }
        

        void Update()
        {   if(move)
            { offset+=speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);            
                if (offset >= 1)
                { move = false;
                offset = 0;      }
            }
}}
