using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "StageInfo",
   menuName = "Pantheon/StageInfo",
   order = 4)
]

public class StageInfo : ScriptableObject
{
    public List<StageModel> StageInfoList = new List<StageModel>();
   
}
[System.Serializable]

public class StageModel
{
    [SerializeField] private string name_;
    public string Name
    {
        get { return name_; }
        protected set { name_ = value; }
    }
    [SerializeField] private int id_;
    public int Id
    {
        get { return id_; }
        set {id_ = value; }
    }
    

    [SerializeField] private GameObject button_;
    public GameObject Button
    {
        get { return button_; }
        protected set { button_ = value; }
    }

    [SerializeField] private BattleInfo battle_info_;
    public BattleInfo BattleInfo
    {
        get { return battle_info_; }
        protected set { battle_info_ = value; }
    }

    [SerializeField] private VisualNovelInfo novel_info_;
    public VisualNovelInfo NovelInfo
    {
        get { return novel_info_; }
        protected set { novel_info_ = value; }
    }

}