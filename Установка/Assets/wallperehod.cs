using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallperehod : MonoBehaviour
{

   

	Animator anim;
	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();   //инициализация контроллера анимации 
	}

	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			anim.SetTrigger("HIT 0");
		}
	}
}
