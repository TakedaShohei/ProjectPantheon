using UnityEngine;
using System.Collections;

public class AIActionAttack : AIActionBase
{

    public AIActionAttack(AIDefine.TargetType target):base(target)
    {

    }

    public override ActionBase Action(AiSetting setting)
    {
        base.Action(setting);

        AttackAction attackAction = new AttackAction();
        attackAction.Entity = setting.Entity;
        attackAction.Target = setting.TargetList[0];
        return attackAction;
    }
}
