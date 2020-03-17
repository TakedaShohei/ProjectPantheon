using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Timers;

public class ActionBase : MonoBehaviour
{
    BattlerBase entity_ = null;
    BattlerBase target_ = null;
    System.Action<ActionBase> cmoplete_action_ = null;
    public BattlerBase Entity
    {
        get { return entity_; }
        set { entity_ = value; }
    }

    public BattlerBase Target
    {
        get { return target_; }
        set { target_ = value; }
    }

    public System.Action<ActionBase> CompleteAction
    {
        get { return cmoplete_action_; }
        set { cmoplete_action_ = value; }
    }


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
    public Timer damage_timer = new Timer(5);
    int counter = 0;

    public ActionBase()
    {
        Init();
    }

    void Init()
    {
        
    }

    /// <summary>
    /// ダメージ処理
    /// <param name="entiry">ダメージを与えるバトラー</param>
    /// <param name="target">ダメージを受けるバトラー)</param>
    /// </summary>
    public void Damge(BattlerBase entiry, BattlerBase target)
    {
        Debug.LogFormat("target.hp_:{0}", target.Status.Hp);
        int damge = entiry.Status.Attack - (target.Status.Defence/2);
        //int damge = (int)(entiry.Status.Attack / (target.Status.Defence / 10));
        if (damge < 1) damge = 1;
        target.Status.Hp -= damge;
        target.Animator.SetTrigger("Damage");
        target.DamageText.Setup(damge);
        target.DamageText.gameObject.SetActive(true);
        target.Hpgauge.UpdateHp(-damge);
        
        

        //target.hpber.update();
        //target.ShowDamge(damge);
        // 演出
        //　死亡したら

        Debug.LogFormat("damge:{0}", damge);
        Debug.LogFormat("target.hp_:{0}", target.Status.Hp);
        if (target.Status.Hp <= 0)
        {
            Debug.Log("you die");
            target.Die();
            
           

        }
    }

    

    public void Damge(BattlerBase entiry, BattlerBase target, float attack_rate)
    {
        Debug.LogFormat("target.hp_:{0}", target.Status.Hp);
        int damge = ((int)(entiry.Status.Attack * attack_rate) - (target.Status.Defence/2));
        //int damge = (int)(entiry.Status.Attack * attack_rate) / (target.Status.Defence / 50);
        if (damge < 1) damge = 1;
        target.DamageText.Setup(damge);
        target.DamageText.gameObject.SetActive(true);
        target.Status.Hp -= damge;
        target.Animator.SetTrigger("Damage");
        
        //target.hpber.update();
        //tarege.ShowDamge(damge);
        // 演出
        //　死亡したら
        if (target.Status.Hp <= 0)
        {
            target.Die();
        }
        Debug.LogFormat("damge:{0}", damge);
        Debug.LogFormat("target.hp_:{0}", target.Status.Hp);
       
    }

    public virtual void Execute( BattleMain battle_main )
    {
        
    }

   

}
