using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using YSFramework;

public class MainPanel : AbsUIPanel 
{
    private Button logoutBtn;
    private Text userNameTxt;

	public override Define.UIType Type 
	{
		get 
		{
			return Define.UIType.MainPanel;
		}
	}


    protected override void OnAwake()
    {
        logoutBtn = transform.FindAndGet<Button>("Scroll View/Viewport/Content/Title/Logout_Btn");
        userNameTxt = transform.FindAndGet<Text>("Scroll View/Viewport/Content/Title/User_Text");
    }

    protected override void OnStart()
    {
        logoutBtn.onClick.AddListener(this.OnLogoutClick);
        userNameTxt.AddPointDownListener(this.OnClickUNameTxt);
    }

    private void OnLogoutClick()
    {
        MessageCenter.Instance.SendMessage(Define.MessageName.Logout, this);
    }

    void OnClickUNameTxt(GameObject listener, object arg, object[] handleParams)
    {
        MessageCenter.SendMessageByName(Define.MessageName.OpenUserUI, this);
    }
}
