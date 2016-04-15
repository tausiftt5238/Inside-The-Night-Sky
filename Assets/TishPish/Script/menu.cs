using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour 
{

	void FixedUpdate ()
	{
		/*if ( Application.platform == RuntimePlatform.IPhonePlayer ||
		    Application.platform == RuntimePlatform.Android )
		{
			if ( Input.touchCount <= 0 )
				return;
			
			// detect single touch only
			Touch touch  = Input.touches[0];
			
			if ( touch.phase == TouchPhase.Began )
			{
				Debug.Log( 123 );
				OnTouchBegan( touch.position );
			}
		}
		else
		{*/
			if ( Input.GetMouseButtonDown( 0 ) )
			{
				Debug.Log(Input.mousePosition);
				OnTouchBegan( Input.mousePosition );
			}
		//}
	}
	
	void OnTouchBegan (Vector2 screenPos)
	{
		Ray ray = Camera.main.ScreenPointToRay( screenPos );
		RaycastHit hit;
		
		if ( Physics.Raycast( ray, out hit, Mathf.Infinity ) )
		{ 
			if (hit.collider.gameObject.name == "box") {
				Debug.Log ("Hit the Barrel");
				Destroy (hit.collider.gameObject);
			}
		}
	}
}
