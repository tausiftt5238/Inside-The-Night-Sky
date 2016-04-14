using UnityEngine;
using System.Collections;

public class showLayer : MonoBehaviour {
	
	public GameObject a;
	void Start () 
	{

	
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) 
		{
			a.layer = LayerMask.NameToLayer("mapcansee");
		}
	
	}
}
