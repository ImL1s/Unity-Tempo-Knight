using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using YSFramework;
using System;

public class LoadingPanel : AbsUIPanel
{
    public override Define.UIType Type
    {
        get
        {
            return Define.UIType.LoadingPanel;	
        }
    }

    public float speed = 10;
    public bool isDebug = false;

    private bool isFinished = false;
    private Image rotateImg;
    private Tweener tweener;
    private float timer = 0;
    private LoadingState loadingState = LoadingState.Normal;
    private Define.LoadingPanelParameter loadingParameter;

    public enum LoadingState
    {
        Normal,
        PrepareToClose,
        Closing,
        Closed
    }


    protected override void OnSetUI(object para)
    {
        if (para != null)
        {
            var lPara = (Define.LoadingPanelParameter)para;
            string msgName = lPara.EventName;
            this.loadingParameter = lPara;
            MessageCenter.Instance.AddListener(lPara.EventName, this.OnReceiveMsg); 
        }
        MessageCenter.AddListenerByName(Define.MessageName.Data_LoadingCompleted, this.OnReceiveMsg);
    }

    protected override void OnEnabled()
    {
        loadingState = LoadingState.Normal;
        transform.localPosition = Vector3.up * Screen.height;
        transform.DOLocalMove(Vector3.zero, 1);
        timer = 0;
    }

    protected override void OnDisabled()
    {
        timer = 0;
    }

    protected override void OnAwake()
    {
        rotateImg = transform.Find("Rotate_Image").GetComponent<Image>();
    }


    protected override void OnStart()
    {
        
    }
	

    protected override void OnUpdate()
    {
        Check();
    }

    private void Check()
    {
        RotateIcon();

        timer += Time.deltaTime;

        if (isFinished)
        {
            if (loadingState == LoadingState.Closing && tweener != null && tweener.IsComplete())
            {
                loadingState = LoadingState.Closed;

                Invoke("Close", 1f);
            }
            if (loadingState == LoadingState.PrepareToClose)
            {
                PlayCloseAnimation();
            }
            else if (loadingState == LoadingState.Normal)
            {
                loadingState = LoadingState.PrepareToClose;
            }
        }
        // 載入超時
        else if (timer >= 20)
        {
            // TODO 跳出錯誤面板
        }
    }

    private void RotateIcon()
    {
        rotateImg.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }

    /// <summary>
    /// 播放關閉動畫
    /// </summary>
    private void PlayCloseAnimation()
    {
        loadingState = LoadingState.Closing;
        tweener = transform.DOLocalMove(Vector3.up * Screen.height, 1);	
        tweener.SetAutoKill(false);
    }

    private void Stop()
    {
        this.isFinished = true;
    }

    private void Close()
    {
        tweener.Kill();
        UIManager.Instance.CloseUI(this);
    }

    private void OnReceiveMsg(Message msg)
    {
        // 如果是接收到的是指定的UI事件
        if (this.loadingParameter != null && msg.Name == this.loadingParameter.EventName && this.loadingParameter.OnFinishAction != null)
        {
            bool succ = loadingParameter.OnFinishAction.Invoke(msg);

            if (succ)
            {
                UIManager.OpenUpUI(loadingParameter.OpenUIType);   
            }
             
            isFinished = true;
        }
        else if(msg.Name == Define.MessageName.Data_LoadingCompleted)
        {
            this.Stop();
        }

    }

    protected override void OnRelease()
    {
        if(this.loadingParameter != null) MessageCenter.RemoveListenerByName(this.loadingParameter.EventName, this.OnReceiveMsg);
        MessageCenter.RemoveListenerByName(Define.MessageName.Data_LoadingCompleted, this.OnReceiveMsg);

        MessageCenter.SendMessageByName(Define.MessageName.UI_LoadingPanelClosed, this);
    }
}
