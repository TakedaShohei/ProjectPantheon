using UnityEngine;
using System.Collections;
using System.Timers;
using System;

public class AttackAction : ActionBase
{

    public override void Execute(BattleMain battle_main)
    {
        
        Entity.Animator.SetTrigger("attack");

        Entity.AttackImpact2 += OnRunImpact;
        Entity.AttackImpact += OnAttackImppact;
        Entity.AttackBack += OnAttackBack;
    }

    private void OnAttackBack()
    {
        Vector3 add_pos = new Vector3();
        add_pos.x = 0;

        Entity.Move(add_pos);
    }

    void OnAttackImppact()
    {
        /*
        GameObject enemy_prefab = (GameObject)Resources.Load(enemy.ModelPrefab);
        GameObject enemy_go = Instantiate(enemy_prefab, target_.EffectTransform);
        */
        //Entity.EffectParticle.Play();
        Damge(Entity, Target);

        CompleteAction(this);


    }
    

    void OnRunImpact()
    {

        Vector3 add_pos = new Vector3();
        add_pos.x = -3;

        Entity.Move(add_pos);
        
    }
    
}
