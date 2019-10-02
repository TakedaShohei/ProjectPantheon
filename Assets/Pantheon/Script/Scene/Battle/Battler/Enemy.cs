using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : BattlerBase
{
    AIBase ai_ = null;
    public AIBase AI
    {
        get { return ai_; }
    }

    public Enemy(EnemyModel model)
    {
        //hp_ = model.hp;
        //ai_ = ai_list[model.ai_id];
        
    }
    
    Dictionary<int,AIBase> ai_list = new Dictionary<int, AIBase>()
    {
        { 1, new AISlime() }
    };

}
