﻿using UnityEngine;
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
    public int id_;
    [SerializeField] private GameObject model_prefab_;
    public GameObject ModelPrefab
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
    [SerializeField] private List<SkillInfo> skill_list_;

 
}