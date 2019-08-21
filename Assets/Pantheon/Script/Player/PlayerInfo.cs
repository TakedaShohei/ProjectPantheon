using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "PlayerInfo",
   menuName = "Pantheon/PlayerInfo",
   order = 2)
]


public class PlayerInfo {
    int current_hp_;
    List<SkillInfo> skill_list_;
    PlayerModel Model;


}

[System.Serializable]

public class PlayerModel
{
    public string name_;
    public int level_;
    public int id_;
    public GameObject model_prefab_;
    public int hp_;
    public int power_;
    public int defense_;
    public List<SkillInfo> skill_list_;



}