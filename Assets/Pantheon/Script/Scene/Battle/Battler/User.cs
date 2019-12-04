using UnityEngine;
using System.Collections;

public class User : BattlerBase
{
    PlayerModel player_model_ = null;
    public void Setup(PlayerModel model)
    {
        hp_ = model.Hp;
        attack_ = model.Power;
        defence_ = model.Defense;
        player_model_ = model;
        Setup();
    }

    public override void DieEffect()
    {
        Animator.SetTrigger("Dead");
        AttackImpact = OnDeathImact;
        
    }
    void OnDeathImact()
    {
        GameObjectBattler.SetActive(false);
        Hpgauge.gameObject.SetActive(false);

    }
}
