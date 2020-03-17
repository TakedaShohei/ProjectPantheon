using UnityEngine;
using UnityEditor;

public class SkillDefence : ActionBase
{
    SkillInfo skill_info_ = null;
    public float deffence_value_ = 0f;

    public override void Execute(BattleMain battle_main)
    {
        //オブジェクト生成
        GameObject skill_effect_go = Instantiate(skill_info_.EffectPrehab, Target.EffectTransform);
        skill_effect_go.transform.localPosition = Vector3.zero;
        skill_effect_go.transform.localRotation = new Quaternion();
        
        //攻撃内容
        float adjust_deffence = (Target.Status.BaseDefence * deffence_value_);
        Debug.Log("adjust_deffence = " + adjust_deffence);
        Target.Status.AdjustDefence += (int)adjust_deffence;

        // アクションが完了した時に知らせる
        CompleteAction(this);
    }

    public void Setvalue(float deffence_value)
    {
        deffence_value_ = deffence_value;
    }

    public void Setuo(SkillInfo skill_info)
    {
        skill_info_ = skill_info;
    }



}