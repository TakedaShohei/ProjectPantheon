using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "BattleInfo",
   menuName = "Pantheon/BattleInfo",
   order = 1)
]

public class BattleInfo : ScriptableObject
{
    public List<BattleModel> BattleInfoList = new List<BattleModel>();


}

[System.Serializable]

public class BattleModel
{
    public int id_;
    public string name_;
    private List<PlayerModel> player_list;
    private List<EnemyModel> enemy_list;
    private string background_prefab_;

}
