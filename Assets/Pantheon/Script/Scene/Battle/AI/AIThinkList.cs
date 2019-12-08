using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIThinkList 
{
    List<AIConditionBase> condition_list_ = null;
    List<AIActionBase> action_list_ = null;

    public List<AIConditionBase> ConditionList
    {
        get { return condition_list_; }
    }
    public List<AIActionBase> ActionList
    {
        get { return action_list_; }
    }

    // コンストラクタ
    public AIThinkList(List<AIConditionBase> condition_list, List<AIActionBase> action_list)
    {
        condition_list_ = condition_list;
        action_list_ = action_list;
    }
}