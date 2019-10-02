using UnityEngine;
using System.Collections;

public class AIData 
{
    int condision_ = 0;
    ActionBase action_ = null;
    public ActionBase Action
    {
        get { return action_; }
    }

    // コンストラクタ
    public AIData(int cond, ActionBase action)
    {
        condision_ = cond;
        action_ = action;
    }
}
