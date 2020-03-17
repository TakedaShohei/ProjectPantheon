using UnityEngine;
using UnityEditor;
using System.Diagnostics;

public class SkillHeal : ActionBase
{

    SkillInfo skill_info_ = null;
    public float timeOut = 2;
    private float timeElapsed = 0;
    public override void Execute(BattleMain battle_main)
    {
        float adjust_hp = (Target.Status.Hp * skill_info_.DamageValue);

        UnityEngine.Debug.Log("adjust_hp = " + adjust_hp);
        Target.Status.Hp+= (int)adjust_hp;
       // GameObject prefab = Resources.Load("Prefab/Battle/Effect/skill/PlasmaExplosionEffect") as GameObject;
        
        //impleachment parcticle
        GameObject skill_effect_go = MonoBehaviour.Instantiate(skill_info_.EffectPrehab, Target.EffectTransform);
        skill_effect_go.transform.localPosition = Vector3.zero;
        skill_effect_go.transform.localRotation = new Quaternion();

        UnityEngine.Debug.Log("回復アクション終了！！！！");
        
        Invoke("ActionComplete", 2.0f);
        
        
    }
    
    void ActionComplete()
    {
        // アクションが完了した時に知らせる
        CompleteAction(this);
    }

    public void Setuo(SkillInfo skill_info)
    {
        skill_info_ = skill_info;
    }
}
   
