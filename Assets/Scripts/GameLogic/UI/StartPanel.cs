using UnityEngine;
using YSFramework;
using System.Collections;
using UnityEngine.UI;

public class StartPanel : AbsUIPanel 
{

	public override Define.UIType Type 
	{
		get 
		{
			return Define.UIType.StartPanel;
		}
	}

	private Button playBtn;


	protected override void OnAwake ()
	{
		playBtn = transform.FindAndGet<Button> ("PlayBtn");
	}

	protected override void OnStart ()
	{
		playBtn.AddPointDownListener (OnPlayBtnClick);
	}

	protected override void OnUpdate ()
	{
		
	}

	private void OnPlayBtnClick(GameObject listener, object arg, object[] handleParams)
	{
		Logger.Debug ("enter game");
	}

}
