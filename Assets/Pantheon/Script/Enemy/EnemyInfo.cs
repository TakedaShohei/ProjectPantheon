using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "EnemyInfo",
   menuName = "Pantheon/EnemyInfo",
   order = 3)
]

public class EnemyInfo : ScriptableObject
{
    public int current_hp_;
    List<SkillInfo> skill_list_;
    EnemyModel Model_;

    /*[MenuItem("Tools/MyTool/Do It in C#")]
    static void DoIt()
    {
        EditorUtility.DisplayDialog("MyTool", "Do It in C# !", "OK", "");
    }*/



}

public class EnemyModel
{
    
}