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
    [SerializeField] private GameObject button_;
    public GameObject Button
    {
        get { return button_; }
        protected set { button_ = value; }
    }
}