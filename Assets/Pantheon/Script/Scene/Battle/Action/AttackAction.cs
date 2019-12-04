using UnityEngine;
using System.Collections;
using System.Timers;
using System;

public class AttackAction : ActionBase
{

    public override void Execute(BattleMain battle_main)
    {
        
        entity_.Animator.SetTrigger("attack");

        entity_.AttackImpact2 += OnRunImpact;
        entity_.AttackImpact += OnAttackImppact;
        entity_.AttackBack += OnAttackBack;
    }

    private void OnAttackBack()
    {
        Vector3 add_pos = new Vector3();
        add_pos.x = 0;
       
        entity_.Move(add_pos);
    }

    void OnAttackImppact()
    {
        /*
        GameObject enemy_prefab = (GameObject)Resources.Load(enemy.ModelPrefab);
        GameObject enemy_go = Instantiate(enemy_prefab, target_.EffectTransform);
        */
        //entity_.Particle.Play();
        Damge(entity_, target_);
       
    }
    

    void OnRunImpact()
    {

        Vector3 add_pos = new Vector3();
        add_pos.x = -3;
       
        entity_.Move(add_pos);
        
    }
    
}
