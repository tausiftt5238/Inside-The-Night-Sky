using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class TorchLight : MonoBehaviour
	{
		
		// The target we are following
		[SerializeField]
		private Transform target;
		// The distance in the x-z plane to the target
		[SerializeField]
		private float distance = 10.0f;
		// the height we want the camera to be above the target
		[SerializeField]
		private float height = 5.0f;
		
		[SerializeField]
		private float rotationDamping;
		[SerializeField]
		private float heightDamping;
		
		// Use this for initialization
		void Start() { }
		
		// Update is called once per frame
		void LateUpdate()
		{
			// Early out if we don't have a target
			if (!target)
				return;
			
			Quaternion cl = transform.rotation;
			Quaternion tl = target.rotation;
			
			Quaternion nl = Quaternion.Lerp (cl, tl, rotationDamping * Time.deltaTime);

			transform.rotation = nl;

			transform.position = target.position - (transform.forward * distance) + (target.up * height);

			//transform.LookAt(target);
		}
	}
}