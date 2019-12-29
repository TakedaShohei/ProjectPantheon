using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "PlayerInfo",
   menuName = "Pantheon/PlayerInfo",
   order = 2)
]

public class PlayerInfo : ScriptableObject
{

    public List<PlayerModel> PlayerInfoList = new List<PlayerModel>();
    private int current_hp_;
    private List<SkillInfo> skill_list_;
    private PlayerModel Model;


}
[System.Serializable]
public class PlayerModel
{
    [SerializeField] private string name_;
    public string Name
    {
           get {return name_;}
           protected set {name_ =value;}
     }

    [SerializeField] private int level_;
    public int Level
    {
        get { return level_;}
        protected set { level_ = value;}
    }
    int id_;
    public int Id
    {
        get { return id_; }
    }
    [SerializeField] private string model_prefab_;
    public string ModelPrefab
    {
        get {return model_prefab_;}
        protected set {model_prefab_ = value;}
    }
    [SerializeField] private int hp_;
    public int Hp
    {
        get {return hp_; }
        protected set {hp_ = value; }
    }
    [SerializeField] private int energy_;
    public int Energy
    {
        get { return energy_; }
        protected set { energy_ = value; }
    }
    [SerializeField] private int power_;
    public int Power
    {
        get { return power_;}
        protected set { power_ = value;}
    }
    [SerializeField] private int defense_;
    public int Defense
    {
        get {return defense_;}
        protected set { defense_ = value; }
    }
    [SerializeField] private GameObject effect_;
    public GameObject Effect
    {
        get { return effect_; }
        protected set { effect_ = value; }
    }
    [SerializeField] private string effect_transform_;
    public string EffectTransform
    {
        get { return effect_transform_; }
        protected set { effect_transform_ = value; }
    }
    [SerializeField] private string player_image_;
    public string PlayerImage
    {
        get { return player_image_; }
        protected set { player_image_ = value; }
    }
    [SerializeField] private List<SkillInfo> skill_list_;
    public List<SkillInfo> SkillList
    {
        get { return skill_list_; }
        protected set { skill_list_ = value; }
    }


}