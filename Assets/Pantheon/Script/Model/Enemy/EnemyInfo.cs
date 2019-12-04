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
    public string Name
    {
        get { return name_; }
        protected set { name_ = value; }
    }
    [SerializeField] private int level_;
    public int Level
    {
        get { return level_; }
        protected set { level_ = value; }
    }
    [SerializeField] private int id_;
    public int Id
    {
        get { return id_; }
        protected set { id_ = value; }
    }
    [SerializeField] private string model_prefab_;
    public string ModelPrefab
    {
        get { return model_prefab_; }
        protected set { model_prefab_ = value; }
    }
    [SerializeField] private int hp_;
    public int Hp
    {
        get { return hp_; }
        protected set { hp_ = value; }
    }
    [SerializeField] private int power_;
    public int Power
    {
        get { return power_; }
        protected set { power_ = value; }
    }
    [SerializeField] private int defense_;
    public int Defense
    {
        get { return defense_; }
        protected set { defense_ = value; }
    }
    [SerializeField] private List<SkillInfo> skill_list_;
    public List<SkillInfo> SkillList
    {
        get { return skill_list_; }
        protected set { skill_list_ = value; }
    }
    [SerializeField] private int position_;
    public int Position
    {
        get { return position_; }
        protected set { position_ = value; }
    }
    [SerializeField] private int ai_id_;
    public int AiId
    {
        get { return ai_id_; }
        protected set { ai_id_ = value; }
    }
}