using UnityEngine;
using System.Collections;

// AIの行動の基底クラス.
public class AIActionBase 
{
    AIDefine.TargetType target_ ;
    public AIDefine.TargetType TargetType
    {
        get { return target_; }
    }

    public AIActionBase(AIDefine.TargetType target)
    {
        target_ = target;
    }

    public virtual ActionBase Action(AiSetting setting)
    {
        if(target_== AIDefine.TargetType.Enemy)
        {
            setting.TargetList.Add(setting.PlayerList[0]);
        }

        return null;
    }
    

}
