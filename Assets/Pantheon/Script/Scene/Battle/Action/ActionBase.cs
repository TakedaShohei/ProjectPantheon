using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Timers;

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
    
    private Timer timer = new Timer(1000/60);
    int counter = 0;

    public ActionBase()
    {
        Init();
    }

    void Init()
    {
        
    }

    public void Damge(BattlerBase entiry, BattlerBase target)
    {
        Debug.LogFormat("target.hp_:{0}", target.hp_);
        int damge = entiry.attack_ - target.defence_;
        target.hp_ -= damge;
        target.Animator.SetTrigger("Damage");
        target.Hpgauge.UpdateHp(-damge);
        

        //target.hpber.update();
        //target.ShowDamge(damge);
        // 演出
        //　死亡したら

        Debug.LogFormat("damge:{0}", damge);
        Debug.LogFormat("target.hp_:{0}", target.hp_);
        if (target.hp_ <= 0)
        {
            Debug.Log("you die");
            target.Die();
            
           
        }
    }

    

    public void Damge(BattlerBase entiry, BattlerBase target, float attack_rate)
    {
        Debug.LogFormat("target.hp_:{0}", target.hp_);
        int damge = (int)(entiry.attack_ * attack_rate) - target.defence_;
        target.hp_ -= damge;
        target.Animator.SetTrigger("Damage");
        
        //target.hpber.update();
        //tarege.ShowDamge(damge);
        // 演出
        //　死亡したら
        if (target.hp_ <= 0)
        {
            target.Die();
        }
        Debug.LogFormat("damge:{0}", damge);
        Debug.LogFormat("target.hp_:{0}", target.hp_);
       
    }

    public virtual void Execute( BattleMain battle_main )
    {
        
    }
    

}
