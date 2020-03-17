using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

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
    BattleUI battle_ui_ = null;
    
    
    public List<User> UserList
    {
        get { return user_list_; }
    }
    public List<Enemy> EnemyList
    {
        get { return enemy_list_; }
    }


    // Use this for initialization
    public void Setup(List<User> player_list, List<Enemy> enemy_list,BattleUI battle_ui)
    {
        user_list_ = player_list;
        enemy_list_ = enemy_list;
        EntryActionBattler();
        FirstActionBattler();
        battle_ui_ = battle_ui;
    }

    // 1ターンで行動するバトラーの登録
    void EntryActionBattler()
    {
        foreach (BattlerBase user in user_list_)
        {
            if (user.State != BattlerBase.ActionState.Dead)
            {
                action_battler_list_.Add(user);
            }
        }

        foreach (BattlerBase enemy in enemy_list_)
        {
            if (enemy.State != BattlerBase.ActionState.Dead)
            {
                action_battler_list_.Add(enemy);
            }
        }

        // 残り時間でソート
        action_battler_list_.Sort((a, b) => a.Status.Speed - b.Status.Speed);
    }

    // 最初に行動するバトラーの設定
    void FirstActionBattler()
    {
        action_battler_list_[0].State = BattlerBase.ActionState.Ready;
    }
    
    // Actionの追加
    public void AddAction(ActionBase action)
    {
        if (action.Entity.State == BattlerBase.ActionState.Dead) return;
        action.Entity.State = BattlerBase.ActionState.Action;
        action_list_.Add(action);
    }

    // Update is called once per frame
    public void Update()
    {
        if (current_battle_state_ != BattleState.InBattle) return;  // バトル中以外は処理しない

        //エネミーが全滅した？　判定
        if (CheckDoomEnemy())
        {
            //BattleEndに移行
            current_battle_state_ = BattleState.BattleEnd;
            Debug.Log(current_battle_state_);
            //アニメーションの再生
            battle_ui_.IndicateBattleClearUI();
        }
        //味方が全滅した？　判定
        if (CheckDoomUser())
        {
            //BattleEndに移行
            current_battle_state_ = BattleState.BattleEnd;
            //アニメーションの再生
            battle_ui_.IndicateExtinctionUI();
        }

        
        if (action_list_ == null || action_list_.Count <= 0) return;

        foreach(ActionBase a in action_list_)
        {
            a.TimeUpdate();
        }

        // 残り時間でActionをソート
        action_list_.Sort((a, b) => a.RemainingTime - b.RemainingTime);

        ActionBase action_top = action_list_[0];

        Debug.LogFormat("action_top entity_:{0} target_:{1} ", action_top.Entity, action_top.Target);

        // Actionが実行可能な場合
        if (action_top.IsReady())
        {

            //  Action完了後の関数を登録
            action_top.CompleteAction = OnActionComplete;

            // Actionの実行
            action_top.Execute(this);
            
            // 実行したActionの削除
            action_list_.RemoveAt(0);
        }
        

    }
    

    // 敵が全滅してるかどうか
    bool CheckDoomEnemy()
    {
        bool result = true;
        foreach(BattlerBase enemy in enemy_list_)
        {
            if (enemy.State != BattlerBase.ActionState.Dead)
            {
                result = false;
            }
           
        }
        return result;
    }

    // 味方が全滅してるかどうか
    bool CheckDoomUser()
    {
        bool result = true;
        foreach (BattlerBase user in user_list_)
        {
            if (user.State != BattlerBase.ActionState.Dead)
            {
                result = false;
            }

        }
        return result;
    }
    
    // Action完了
    void OnActionComplete(ActionBase action)
    {
        ChangeNextReadyBattler(action.Entity);
        
    }
    
    // 次の行動可能なバトラーの設定
    void ChangeNextReadyBattler(BattlerBase exec_battler)
    {
        action_battler_list_.Remove(exec_battler);

        // 全てのバトラーの行動が完了した場合は、再登録
        if (action_battler_list_.Count <= 0)
        {
            // 次のターンのアクション可能なバトラーを登録
            EntryActionBattler();
            //スキルの待ち時間を進める
            SkillWaitCountDown();
        }

        // 次のバトラーを行動可能状態にする
        if(action_battler_list_[0].State != BattlerBase.ActionState.Dead)
        {
            action_battler_list_[0].State = BattlerBase.ActionState.Ready;
        }
        
    }

    // スキルの待ち時間を進める
    void SkillWaitCountDown()
    {
        foreach (User user in user_list_)
        {
            if (user.State != BattlerBase.ActionState.Dead)
            {
                user.SkillWaitCountDown();
            }

        }
    }
    
}
