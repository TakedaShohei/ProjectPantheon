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

[SerializeField]
public class PlayerModel
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