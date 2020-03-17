using UnityEngine;
using UnityEditor;

public class SkillDebuff : ActionBase
{
    SkillInfo skill_info_ = null;
    public float decrease_damage = 0;
    public override void Execute(BattleMain battle_main)
    {
        float adjust_attack = (Target.Status.BaseAttack * decrease_damage);
        Debug.Log("adjust_deffence = " + adjust_attack);
        Target.Status.AdjustAttack -= (int)adjust_attack;

        GameObject prefab = Resources.Load("Prefab/Battle/Effect/skill/PlasmaExplosionEffect") as GameObject;

        //impleachment parcticle
        GameObject skill_effect_go = MonoBehaviour.Instantiate(prefab, Target.EffectTransform);
        skill_effect_go.transform.localPosition = Vector3.zero;
        skill_effect_go.transform.localRotation = new Quaternion();

        // アクションが完了した時に知らせる
        CompleteAction(this);
        
    }

    public void Setvalue(float decrease_damage_)
    {
        decrease_damage_ = decrease_damage;
    }

    public void Setuo(SkillInfo skill_info)
    {
        skill_info_ = skill_info;
    }

}