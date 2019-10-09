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
        //ai_ = GetAI(model.ai_id);


    }

    AIBase GetAI(int ai_id)
    {
        if (ai_id == 1) { return new AISlime(); }
        if (ai_id == 2) { return new ADragon(); }

        return null;
    }

    

}
