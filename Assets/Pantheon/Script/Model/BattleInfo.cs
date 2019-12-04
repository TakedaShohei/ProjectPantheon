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

        [SerializeField]public string background_prefab_;
        public string Background_prehab_
        {
            get { return background_prefab_; }
            protected set { background_prefab_ = value; }
    
        }

        [SerializeField] private GameObject attack_;
        public GameObject Attack_
        {
            get { return attack_; }
            protected set { attack_ = value; }
        }
    }


}

