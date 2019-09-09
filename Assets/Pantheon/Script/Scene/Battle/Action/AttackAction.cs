using UnityEngine;
using System.Collections;

public class AttackAction : ActionBase
{
    public override void Execute(BattleMain battle_main)
    {
        Damge(entity_, target_);
        //固有の演出があれば
        //固有の処理があれば

    }
}
