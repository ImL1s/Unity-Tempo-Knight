using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TestSlider : MonoBehaviour 
{
	public float moveSpeed = 1;

	private Slider slider;
	private Transform handle;
	private Transform damageBlocks;

	private GameObject damageBlock;

	private bool isLeft = true;
	private float monsterAttackSpeed = 2;
	private float timer = 0;
	float width;						 				// 當前Slider寬度

	void Awake()
	{
		slider = GetComponent<Slider> ();
		handle = slider.transform.Find ("Handle Slide Area/Handle");
		damageBlocks = transform.Find ("DamageBlocks");
		damageBlock = Resources.Load<GameObject> ("DamageBlock");
		timer = Time.time;
		width =  ((RectTransform)transform).rect.width;
	}

	void Start () 
	{


		slider.value = 0;
		print (handle.position);
		print (handle.localPosition);

		slider.value = 50;
		print (handle.position);
		print (handle.localPosition);

	}

	void Update () 
	{
		SliderMove ();
		InstantiateDamageBlock ();
//		print (Time.time);
	}

	private void SliderMove()
	{
		if(isLeft)
		{
			slider.value += moveSpeed * Time.deltaTime;

			if(slider.value >= 100)
			{
				isLeft = false;
			}
		}

		else
		{
			slider.value -= moveSpeed * Time.deltaTime;

			if(slider.value <= 0)
			{
				isLeft = true;
			}
		}
	}

	private void InstantiateDamageBlock()
	{
		if(Time.time - timer > monsterAttackSpeed)
		{
			timer = Time.time;

			GameObject go = Instantiate (damageBlock, this.damageBlocks) as GameObject;
			SetPos (go);
			SetScript<DamageBlock>(go);
		}
	}

	private void SetPos(GameObject go)
	{
		go.transform.localPosition = Vector3.zero;
//		float parentWidth = ((RectTransform)transform).rect.width;
		float x =(float) (width * 0.5f + 10 * 2);
		go.transform.localPosition = Vector3.right * x;
	}

	private void SetScript<T>(GameObject go) where T:BaseBlock
	{
		T scrpt = go.AddComponent<T> ();
		scrpt.EndPoint = Vector3.left * (width * 0.5f + 10 * 2);
		scrpt.MoveSpeed = 2;
	}	
}
