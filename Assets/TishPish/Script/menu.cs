using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	void OnMouseDown()
	{
		Destroy(gameObject);
		Application.LoadLevel("level1");
	}

}
