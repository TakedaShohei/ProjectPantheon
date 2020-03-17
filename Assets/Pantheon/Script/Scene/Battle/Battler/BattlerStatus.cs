using UnityEngine;
using System.Collections;

public class BattlerStatus
{
    int hp_ = 0;
    public int Hp
    {
        get { return hp_; }
        set { hp_ = value; }
    }

    int max_hp_ = 0;
    public int MaxHp
    {
        get { return max_hp_; }
    }

    int base_attack_ = 0;
    public int BaseAttack
    {
        get { return base_attack_; }
    }
    
    public int Attack
    {
        get { return base_attack_ + adjust_attack_; }
    }

    int adjust_attack_ = 0;
    public int AdjustAttack
    {
        get { return adjust_attack_; }
        set { adjust_attack_ = value; }
    }

    int base_defence_ = 0;
    public int BaseDefence
    {
        get { return base_defence_; }
    }
    
    public int Defence
    {
        get { return base_defence_ + adjust_defence_; }
    }

    int adjust_defence_ = 0;
    public int AdjustDefence
    {
        get { return adjust_defence_; }
        set { adjust_defence_ = value; }
    }

    int speed_ = 0;
    public int Speed
    {
        get { return speed_; }
        set { speed_ = value; }
    }

    int adjust_speed_ = 0;
    public int AdjustSpeed
    {
        get { return adjust_speed_; }
        set { adjust_speed_ = value; }
    }

    public void Setup(PlayerModel model)
    {
        max_hp_ = model.Hp;
        hp_ = model.Hp;
        base_attack_ = model.Power;
        base_defence_ = model.Defense;
    }

    public void Setup(EnemyModel model)
    {
        max_hp_ = model.Hp;
        hp_ = model.Hp;
        base_attack_ = model.Power;
        base_defence_ = model.Defense;
    }
}
