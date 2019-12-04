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
        [SerializeField] private string scene_name_;
        public string Scene_Name_
        {
            get { return scene_name_; }
            protected set { scene_name_ = value; }
        }

        [SerializeField] private int scene_id_;
        public int Scene_Id_
        {
            get { return scene_id_; }
            protected set { scene_id_ = value; }
        }

        [SerializeField] private int novel_id_;
        public int novel_Id_
        {
            get { return novel_id_; }
            protected set { novel_id_ = value; }
        }
         

        [SerializeField] private int battle_id_;
        public int Battle_Id_
        {
            get { return battle_id_; }
            protected set { battle_id_ = value; }
        }

    }

}


