using UnityEngine;
using System.Collections;

public class BattleScene : MonoBehaviour, ISceneWasLoaded
{
    BattleMain battle_main_ = null;
    StageModel model_ = null;
    
   // [SerializeField] PlayerCommoandUI player_commaond_ui_ = null;


    public void OnSceneWasLoaded(object argument)
    {
        model_ = argument as StageModel;
        Debug.Log("OnSceneWasLoaded." + model_.Id + " " + model_.Name);
    }

    void Setup()
    {

        battle_main_ = new BattleMain();

        // 背景をロードして配置
        CreateBackground();

        // 敵キャラクターのロードして配置
        CreateEnemy();

        // 味方キャラクターのロードして配置

        // UIの初期化
        //player_commaond_ui_.Setup(battle_main_);

        // 準備が整ったらバトルスタート
    }

    void CreateBackground()
    {
        // 一旦はバトルはリストの0番目のみ
        GameObject bg = Resources.Load(model_.BattleInfo.BattleInfoList[0].background_prefab_) as GameObject;
        Instantiate(bg, new Vector3(0, 0, 0), Quaternion.identity);
        
    }

    void CreateEnemy()
    {
        BattleModel battle_model = model_.BattleInfo.BattleInfoList[0];
        foreach(EnemyModel enemy in battle_model.enemy_list)
        {

        }
    }



    // Use this for initialization
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        battle_main_.Update();
    }
}
