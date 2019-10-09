using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIBase 
{
    public virtual List<AIThinkList> GetAIThinkList() { return null; }

    public List<ActionBase> SelectAI(AiSetting setting)
    {
        List<AIThinkList> ai_think_list = GetAIThinkList();
        for(var i = 0; i < ai_think_list.Count; i++)
        {
            AIThinkList data = ai_think_list[i];
            bool mach = MachConditioon(data, setting);
            if (mach)
            {
                return data.ActionList;
            }
        }
        return null;
    }

    public bool MachConditioon(AIThinkList data, AiSetting setting)
    {
        //settingの様々な値と、dataの条件がマッチするかを書いていく.
        List<AIConditionBase> condition_list = data.ConditionList;
        for(var i=0;i< condition_list.Count; i++)
        {
            if (condition_list[i].CheckCOondition(setting) == true)
            {
                return true;
            }
        }

        return false;
    }
    
}
