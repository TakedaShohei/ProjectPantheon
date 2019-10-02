using UnityEngine;
using System.Collections;

public class ActionBase
{
    public BattlerBase entity_ = null;
    public BattlerBase target_ = null;


    private int remaining_time;
    public int RemainingTime
    {
        get { return remaining_time; }
    }
    private int speed = 1;

    public void TimeUpdate()
    {
        remaining_time -= speed;
    }

    public bool IsReady()
    {
        if (remaining_time <= 0)
        {
            return true;
        }
        return false;
    }

    public void Damge(BattlerBase entiry, BattlerBase target)
    {
        int damge = entiry.attack_ - target.defence_;
        target.hp_ -= damge;
        //target.hpber.update();
        //tarege.ShowDamge(damge);
        // 演出
        //　死亡したら
    }

    public virtual void Execute( BattleMain battle_main )
    {
        
    }
    
}
