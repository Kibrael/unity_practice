using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public CharacterController Character;
	
	public float Speed;
	public Vector3 MoveSpeed;
	public Vector3 RotateSpeed;
	// Update is called once per frame
	void Update ()
	{
		//Update() performs updates every frame

		MoveSpeed.x += Speed * Input.GetAxis("Horizontal"); //pulls input from horizontal keys or controller pad
		MoveSpeed *= Time.deltaTime; //smoothing function for display and processing

		Character.Move(MoveSpeed);
	}
}
//transform relates to transform menu in unity objects
//public variables show up in inspector window for object they have the scripts