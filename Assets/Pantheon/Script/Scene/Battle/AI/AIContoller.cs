using UnityEngine;
using System.Collections;

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
        Enemy enemy = GetEnemy();
        if(enemy.State == Enemy.ActionState.Ready)
        {
            AIBase ai = enemy.AI;
            AiSetting ai_setting = new AiSetting();
            
            AIData exec_ai_data = ai.SelectAI(ai_setting);
            battle_main_.AddAction(exec_ai_data.Action);

        }
        
    }



    public Enemy GetEnemy()
    {
        return null;
    }

}

