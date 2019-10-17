using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(
   fileName = "StageMoveInfo",
   menuName = "Pantheon/StageMoveInfo",
   order = 13)
]

public class StageMoveInfo :ScriptableObject
{
    public string comment;
    public List<StageMoveModel> PositionInfoList = new List<StageMoveModel>();

    [System.Serializable]
    public class StageMoveModel
    {
        public string comment;
        public int scene_Id_;
        public string scene_Name_;
        public int novel_Id_;
        public int battle_Id_;
    }

}


