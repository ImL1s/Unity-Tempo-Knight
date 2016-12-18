using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserPanel : AbsUIPanel 
{
    private Button outBtn;

    public override Define.UIType Type
    {
        get
        {
            return Define.UIType.UserPanel;
        }
    }

    protected override void OnSetUI(object para)
    {
        // TODO 將資料初始化到介面上
    }

    protected override void OnAwake()
    {
        outBtn = transform.FindAndGet<Button>("Title/Exit_Button");
    }

    protected override void OnStart()
    {
        outBtn.AddPointDownListener(this.OnExitBtnClick);
    }

    private void OnExitBtnClick(GameObject listener, object arg, object[] handleParams)
    {
        MessageCenter.SendMessageByName(Define.MessageName.Logout, this);
    }
}
