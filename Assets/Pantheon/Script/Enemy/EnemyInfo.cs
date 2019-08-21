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
    public List<EnemyModel> EnemyInfoList = new List<EnemyModel>();
    private int current_hp_;
    List<SkillInfo> skill_list_;
    EnemyModel Model_;

    /*[MenuItem("Tools/MyTool/Do It in C#")]
    static void DoIt()
    {
        EditorUtility.DisplayDialog("MyTool", "Do It in C# !", "OK", "");
    }*/



}
[SerializeField]
public class EnemyModel
{
    private string name_;
    private int level_;
    private int id_;
    private GameObject model_prefab_;
    private int hp_;
    private int power_;
    private int defense_;
    private List<SkillInfo> skill_list_;
}