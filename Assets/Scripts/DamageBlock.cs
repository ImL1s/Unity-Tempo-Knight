using UnityEngine;
using System.Collections;

public class DamageBlock : BaseBlock 
{



	// Update is called once per frame
	void Update () 
	{
		RTransform.position += Vector3.left * MoveSpeed;

		if(RTransform.localPosition.x <= EndPoint.x)
		{
			//			Destroy (gameObject);
			DestroyImmediate (gameObject);
		}
	}
}
