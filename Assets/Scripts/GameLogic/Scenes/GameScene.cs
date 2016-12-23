using UnityEngine;
using YSFramework;
using System.Collections;

public class GameScene : AbsScene
{

    protected override void OnInit(object para)
    {
        Logger.Debug("OnInit");
    }

    public override void Onload()
    {
        UIManager.OpenUpUI(Define.UIType.GamePanel);
    }


}
