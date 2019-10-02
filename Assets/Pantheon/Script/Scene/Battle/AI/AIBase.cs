using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIBase 
{
    public virtual List<AIData> GetAIDataList() { return null; }

    public AIData SelectAI(AiSetting setting)
    {
        List<AIData> ai_data_list = GetAIDataList();
        for(var i = 0; i < ai_data_list.Count; i++)
        {
            AIData data = ai_data_list[i];
            bool mach = MachConditioon(data, setting);
            if (mach)
            {
                return data;
            }
        }
        return null;
    }

    public bool MachConditioon(AIData data, AiSetting setting)
    {
        //settingの様々な値と、dataの条件がマッチするかを書いていく.
        return true;
    }
    
}
