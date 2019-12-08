using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AiSetting
{
    List<User> player_list_ = null;
    List<Enemy> enemy_list_ = null;
    List<BattlerBase> target_list_ = new List<BattlerBase>();
    BattlerBase entity_ = null;
    public List<BattlerBase> TargetList
    {
        get { return target_list_; }
    }
    public List<User> PlayerList
    {
        get { return player_list_; }
    }
    public List<Enemy> EnemyList
    {
        get { return enemy_list_; }
    }
    public BattlerBase Entity
    {
        get { return entity_; }
        set { entity_ = value; }
    }


    public AiSetting(BattleMain battle_main)
    {
        player_list_ = battle_main.UserList;
        enemy_list_ = battle_main.EnemyList;
    }
}
