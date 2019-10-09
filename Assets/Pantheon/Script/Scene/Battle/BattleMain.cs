using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class  BattleMain
{
    
    List<ActionBase> action_list_ = new List<ActionBase>();
    List<User> user_list_ = new List<User>();
    List<Enemy> enemy_list_ = new List<Enemy>();

    public List<Enemy> EnemyList
    {
        get { return enemy_list_; }
    }


    // Use this for initialization
    void Setup(List<User>user_list, List<Enemy>enemy_list)
    {
        user_list_ = user_list;
        enemy_list_ = enemy_list;
    }

   

    public void AddAction(ActionBase action)
    {
        action_list_.Add(action);
    }

    // Update is called once per frame
    public void Update()
    {
        foreach(ActionBase a in action_list_)
        {
            a.TimeUpdate();
        }

        // 残り時間でソート
        action_list_.Sort((a, b) => a.RemainingTime - b.RemainingTime);

        ActionBase action_top = action_list_[0];

        if (action_top.IsReady())
        {
            action_top.Execute(this);
            action_list_.RemoveAt(0);
        }
    }
}
