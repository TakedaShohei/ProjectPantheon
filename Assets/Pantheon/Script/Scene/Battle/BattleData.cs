using UnityEngine;
using System.Collections;
using static BattleInfo;

public class BattleData 
{
    private static StageModel stage_model_ = null;
    public static StageModel StageModel
    {
        get { return stage_model_;  }
    }
    public static void SetStageModel(StageModel stage_model)
    {
        stage_model_ = stage_model;
    }


}
