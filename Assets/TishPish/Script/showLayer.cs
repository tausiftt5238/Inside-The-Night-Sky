using UnityEngine;
using System.Collections;

public class showLayer : MonoBehaviour {

	//GameObject player;
	void Start () 
	{
		//player = Camera.main;
	}

	void Update () {

		Vector3 vv = gameObject.transform.position;
		float dis = vv.x- Camera.main.transform.position.x;
		Debug.Log(dis);

		if (Input.GetKeyDown(KeyCode.A)) 
		{
			if (dis<=50)
			{
				Transform[] ts = GetComponentsInChildren<Transform>(true);
				foreach(Transform t in ts)
				{
					t.gameObject.layer = LayerMask.NameToLayer("mapcansee");
				}
			}
		}
	
	}
}
