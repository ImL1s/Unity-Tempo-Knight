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

    private Button optionBtn;


	protected override void OnAwake ()
	{
		playBtn = transform.FindAndGet<Button> ("PlayBtn");
        optionBtn = transform.FindAndGet<Button>("OptionBtn");
        
    }

	protected override void OnStart ()
	{
		playBtn.AddPointDownListener (OnPlayBtnClick);
        optionBtn.AddPointDownListener(OnOptionBtnClick);
    }

	protected override void OnUpdate ()
	{
		
	}

	private void OnPlayBtnClick(GameObject listener, object arg, object[] handleParams)
	{
		Logger.Debug ("enter game");
        SceneManagerEX.Instance.ChangeSceneDirect(Define.SceneType.GameScene);
    }

    private void OnOptionBtnClick(GameObject listener, object arg, object[] handleParams)
    {
        Logger.Debug("open option");
    }

}
