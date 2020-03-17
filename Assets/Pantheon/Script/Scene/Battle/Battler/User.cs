using UnityEngine;
using System.Collections;

public class User : BattlerBase
{
    public PlayerModel PlayerModel
    {
        get { return player_model_; }
    }
    PlayerModel player_model_ = null;
    public void Setup(PlayerModel model)
    {
        Setup();
        Status.Setup(model);
        player_model_ = model;
        SkillWaitCountReset();
    }

    public override void DieEffect()
    {
        Animator.SetTrigger("Dead");
        AttackImpact = OnDeathImact;
        
    }

    // スキル待ち時間を進める
    public void SkillWaitCountDown()
    {
        foreach(SkillInfo skill in player_model_.SkillList)
        {
            if (0 < skill.CurrentWaitTurn) skill.CurrentWaitTurn--;
        }
    }

    // スキル待ち時間をリセット
    public void SkillWaitCountReset()
    {
        foreach (SkillInfo skill in player_model_.SkillList)
        {
            skill.CurrentWaitTurn = 0;
        }
    }

    void OnDeathImact()
    {
        GameObjectBattler.SetActive(false);
        Hpgauge.gameObject.SetActive(false);

    }
}
