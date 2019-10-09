using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIContoller : MonoBehaviour
{
    BattleMain battle_main_ = null;


    public void Setup(BattleMain battle_main)
    {
        battle_main_ = battle_main;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        List<Enemy> enemy_list = GetEnemyList();
        foreach(Enemy enemy in enemy_list)
        {
            if (enemy.State == Enemy.ActionState.Ready)
            {
                AIBase ai = enemy.AI;
                AiSetting ai_setting = new AiSetting();

                List<ActionBase> exec_action_list = ai.SelectAI(ai_setting);
                foreach (ActionBase exec_action in exec_action_list)
                {
                    battle_main_.AddAction(exec_action);
                }

            }
        }
    }



    public List<Enemy> GetEnemyList()
    {
        return battle_main_.EnemyList;
    }

}

