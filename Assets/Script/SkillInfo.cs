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
    private int used_turn_;
    public List<SkillInfoData> SkillInfoList = new List<SkillInfoData>();


}

[System.Serializable]

public class SkillInfoData
{
    public string name = "ファイア";
    public int id = 1;
    public int value = 10;

}