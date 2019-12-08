﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class  BattleMain
{
    public enum BattleState
    {
        PreBattle,
        InBattle,
        BattleEnd
    }

    BattleState current_battle_state_ = BattleState.PreBattle;
    public BattleState CurrentBattleState
    {
        get { return current_battle_state_; }
        set { current_battle_state_ = value; }
    }

    List<ActionBase> action_list_ = new List<ActionBase>();
    List<User> user_list_ = null;
    List<Enemy> enemy_list_ = null;
    List<BattlerBase> action_battler_list_ = new List<BattlerBase>();



    public List<User> UserList
    {
        get { return user_list_; }
    }
    public List<Enemy> EnemyList
    {
        get { return enemy_list_; }
    }


    // Use this for initialization
    public void Setup(List<User> player_list, List<Enemy> enemy_list)
    {
        user_list_ = player_list;
        enemy_list_ = enemy_list;
        ClearActionBattler();
    }

   

    public void AddAction(ActionBase action)
    {
        action_list_.Add(action);
    }

    // Update is called once per frame
    public void Update()
    {
        if (current_battle_state_ != BattleState.InBattle) return;
        if (action_list_ == null || action_list_.Count <= 0) return;

        foreach(ActionBase a in action_list_)
        {
            a.TimeUpdate();
        }

        // 残り時間でソート
        action_list_.Sort((a, b) => a.RemainingTime - b.RemainingTime);

        ActionBase action_top = action_list_[0];

        Debug.LogFormat("action_top entity_:{0} target_:{1} ", action_top.Entity, action_top.Target);

        if (action_top.IsReady())
        {
            action_top.Execute(this);
            action_top.CompleteAction = OnActionComplete;
            
            action_list_.RemoveAt(0);
        }
    }

    void OnActionComplete(ActionBase action)
    {
        ChangeActiveBattler(action.Entity);
    }



    void ChangeActiveBattler(BattlerBase exec_battler)
    {
        action_battler_list_.Remove(exec_battler);
        if (action_battler_list_.Count <= 0)
        {
            ClearActionBattler();
        }

        action_battler_list_[0].State = BattlerBase.ActionState.Ready;


    }

    void ClearActionBattler()
    {
        foreach(BattlerBase enemy in enemy_list_)
        {
            action_battler_list_.Add(enemy);
        }

        foreach (BattlerBase user in user_list_)
        {
            action_battler_list_.Add(user);
        }
    }
}
