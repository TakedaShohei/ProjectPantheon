using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIContoller : MonoBehaviour
{
   public BattleMain battle_main_ = null;
    AiSetting ai_setting_ = null;

    public void Setup(BattleMain battle_main)
    {
        battle_main_ = battle_main;

        ai_setting_ = new AiSetting(battle_main);

        List<Enemy> enemy_list = GetEnemyList();
        foreach (Enemy enemy in enemy_list)
        {
            //enemy.State = Enemy.ActionState.Ready;
        }


    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        List<Enemy> enemy_list = GetEnemyList();
       
        foreach (Enemy enemy in enemy_list)
        {
            if (enemy.State == Enemy.ActionState.Ready)
            {
                enemy.State = Enemy.ActionState.Action;
                AIBase ai = enemy.AI;
                ai_setting_.Entity = enemy;

                List<AIActionBase> exec_action_list = ai.SelectAI(ai_setting_);
                foreach (AIActionBase exec_action in exec_action_list)
                {
                    battle_main_.AddAction(exec_action.Action(ai_setting_));
                }
                

            }
        }
    }



    public List<Enemy> GetEnemyList()
    {
        if (battle_main_ == null) return null;
        return battle_main_.EnemyList;
    }

}

