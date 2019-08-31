using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "SkillInfo",
   menuName = "Pantheon/SkillInfo",
   order = 0)
]

public class SkillInfo : ScriptableObject
{
    public List<SkillModel> SkillInfoList = new List<SkillModel>();
    private int used_turn_;

}

[System.Serializable]

public class SkillModel
{
    public string name_ = "ファイア";
    public int id_ = 1;
    public int value_ = 10;
    public GameObject effect_prehab;
    

}
 