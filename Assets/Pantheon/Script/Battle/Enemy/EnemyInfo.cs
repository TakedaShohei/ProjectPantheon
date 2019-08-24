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
[System.Serializable]

public class EnemyModel
{
    [SerializeField] private string name_;
    [SerializeField] private int level_;
    [SerializeField] private int id_;
    [SerializeField] private GameObject model_prefab_;
    [SerializeField] private int hp_;
    [SerializeField] private int power_;
    [SerializeField] private int defense_;
    [SerializeField] private List<SkillInfo> skill_list_;
}