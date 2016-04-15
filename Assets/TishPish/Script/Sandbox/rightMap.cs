using UnityEngine;
using System.Collections;

public class rightMap : MonoBehaviour {

	public GameObject player;
	public GameObject prefab;
	int []right;
	void Start () 
	{
		right = new int[100];
		foreach (int z in right) {
			right [z] = 0;
			//top [z] = 0;
		}

			
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		int z1 = (int) (player.transform.position.x+100)/1500;
		float dis1 = 1500+z1*1500 - player.transform.position.x;

		Debug.Log("dos"+ dis1);
		if (right[z1]==0 && dis1 <1550) 
		{
			Vector3 pos = new Vector3 (1500*z1, -9.52f, 0);
			Instantiate (prefab, pos, Quaternion.identity);
			//done =true;
			Debug.Log("instantiated");
			right[z1]=1;
		}

		
	}
}
