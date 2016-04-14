using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour {

	public Animation anima;
	void Start () {
		anima = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey ("left")){
			//transform.position.x = transform.position.x - 0.1;
			anima.Play("take 001");
		}
		
		if(!Input.GetKey ("left")){
			anima.Play("take 002");
		}
	
	}
}
