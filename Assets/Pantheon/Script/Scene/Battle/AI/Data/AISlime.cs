using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AISlime : AIBase
{
 
    private List<AIThinkList> ai_list_ = new List<AIThinkList>
    {
        // 第一条件
        new AIThinkList(
            // 条件
            // 10%の確立
            //
            new List<AIConditionBase>
            {
                new AICondtion_Randam(10)
            },
            // 行動
            // 強攻撃
            new List<ActionBase>
            {
                new StrongAttackAction()
            }
            ),
        // 第二条件
        new AIThinkList(
             // 条件
            // 常に
            new List<AIConditionBase>
            {
                new AICondtion_AnyOK()
            },
            // 行動
            // 攻撃
            new List<ActionBase>
            {
                new AttackAction()
            }

            )
    };

    public override List<AIThinkList> GetAIThinkList() { return ai_list_; }
}
