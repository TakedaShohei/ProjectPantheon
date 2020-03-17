using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : BattlerBase
{
    AIBase ai_ = null;
    public AIBase AI
    {
        get { return ai_; }
    }

    EnemyModel enemy_model = null;

    public void  Setup(EnemyModel model)
    {
        base.Setup();
        Status.Setup(model);
        ai_ = GetAI(model.AiId);
        enemy_model = model;
        
    }

    AIBase GetAI(int ai_id)
    {
        if (ai_id == 1) { return new AISlime(); }
        if (ai_id == 2) { return new ADragon(); }

        return null;
    }

    public override void DieEffect()
    {
        Animator.SetTrigger("Dead");
        
        AttackImpact = OnDeathImact;
        Debug.Log("RIP");
    }
    void OnDeathImact()
    {
        GameObjectBattler.SetActive(false);
        Hpgauge.gameObject.SetActive(false);

        
    }

}
