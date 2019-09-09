using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class  BattleMain
{
    
    List<ActionBase> action_list = new List<ActionBase>();

    // Use this for initialization
    void Setup()
    {

    }

   

    public void AddAction(ActionBase action)
    {
        action_list.Add(action);
    }

    // Update is called once per frame
    public void Update()
    {
        foreach(ActionBase a in action_list)
        {
            a.TimeUpdate();
        }

        // 残り時間でソート
        action_list.Sort((a, b) => a.RemainingTime - b.RemainingTime);

        ActionBase action_top = action_list[0];

        if (action_top.IsReady())
        {
            action_top.Execute(this);
            action_list.RemoveAt(0);
        }
    }
}
