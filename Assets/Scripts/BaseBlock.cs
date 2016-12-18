using UnityEngine;
using System.Collections;

public class BaseBlock : MonoBehaviour 
{

	public float MoveSpeed{ get; set;}
	public Vector3 EndPoint{ get; set;}

	protected RectTransform RTransform
	{
		get
		{
			if (mRTransform == null)
				mRTransform = GetComponent<RectTransform> ();

			return mRTransform;
		}
	}

	private RectTransform mRTransform;
}
