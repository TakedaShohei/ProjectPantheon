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

    [System.Serializable]

    public class BattleModel
    {
        [SerializeField] private string name_;
        public string Name
        {
            get { return name_; }
            protected set { name_ = value; }
        }
        public int id_;
        [SerializeField] private GameObject model_prefab_;
        public GameObject ModelPrefab
        {
            get { return model_prefab_; }
            protected set { model_prefab_ = value; }
        }
        [SerializeField] public List<EnemyModel> enemy_list;
        public List<EnemyModel> Enemy_List
        {
            get { return enemy_list; }
            protected set { enemy_list = value; }
        }
        public string background_prefab_;

        [SerializeField] private GameObject background_;
        public GameObject Background_
        {
            get { return background_; }
            protected set { background_ = value; }
        }
    }


}

