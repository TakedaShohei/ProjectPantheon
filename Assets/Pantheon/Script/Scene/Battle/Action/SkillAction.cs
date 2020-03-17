using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class SkillAction :ActionBase
{

    public float damage_value_ = 0;
    SkillInfo skill_info_ = null;
    // アクションが実行された時の処理
    public override void Execute(BattleMain battle_main)
    {
        GameObject skill_effect_go = Instantiate(skill_info_.EffectPrehab, Target.EffectTransform);
        skill_effect_go.transform.localPosition = Vector3.zero;
        skill_effect_go.transform.localRotation = new Quaternion();
        float adjust_attack = (Target.Status.BaseAttack * damage_value_);

        Debug.Log("adjust_deffence = " + adjust_attack);
        Target.Status.AdjustAttack += (int)adjust_attack;



        // アクションが完了した時に知らせる
        CompleteAction(this);
    }
 
    public void Setvalue(float damege_value)
    {
        damage_value_ = damege_value;
    }

    public void Setuo(SkillInfo skill_info)
    {
        skill_info_ = skill_info;
    }

}