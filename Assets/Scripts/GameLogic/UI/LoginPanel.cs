using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening.Core;
using DG.Tweening;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using YSFramework;

public class LoginPanel : AbsUIPanel
{

    public override Define.UIType Type
    {
        get
        {
            return Define.UIType.LoginPanel;
        }
    }

    private InputField accountField;
    private InputField pwdField;
    private Button loginBtn;

    private int currentField = -1;
    private List<InputField> fieldList = new List<InputField>();


    protected override void OnAwake()
    {
        accountField = transform.Find("Account_Field/InputField").GetComponent<InputField>();
        pwdField = transform.Find("Pwd_Field/InputField").GetComponent<InputField>();
        loginBtn = transform.Find("Login_Button").GetComponent<Button>();

        fieldList.AddRange(transform.GetComponentsInChildren<InputField>());
    }

    protected override void OnStart()
    {
        loginBtn.onClick.AddListener(this.OnLoginBtnClick);
    }


    protected override void OnUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            currentField++;
            currentField %= 2;

            EventSystem.current.SetSelectedGameObject(fieldList[currentField].gameObject);
        }
    }

    private void OnLoginBtnClick()
    {
        var para = new Define.LoadingPanelParameter()
        {
            EventName = Define.MessageName.OnLogin,
            OpenUIType = Define.UIType.MainPanel,
            OnFinishAction = (msg) =>
            {
                // TODO 實現網路登錄
                //                                if(msg.GetContent<Define.LoginResult>() == Define.LoginResult.Succ) return true;
                //                                else return false;

                return true;
            }
        };

        UIManager.OpenUpUI(
            Define.UIType.LoadingPanel,
            closeOther: false,
            UIParas: para);

        UnityCoroutine.Instance.AsyncAction(this.TestOnLoginMessage, 2f);
    }

    // 測試方法
    private void TestOnLoginMessage()
    {
        // TODO TEST
        MessageCenter.Instance.SendMessage(Define.MessageName.OnLogin, this);
    }
}
