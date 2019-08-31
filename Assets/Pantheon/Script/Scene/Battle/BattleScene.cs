using UnityEngine;
using System.Collections;

public class BattleScene : MonoBehaviour, ISceneWasLoaded
{
    StageModel model_ = null;

    public void OnSceneWasLoaded(object argument)
    {
        model_ = argument as StageModel;
        Debug.Log("OnSceneWasLoaded." + model_.Id + " " + model_.Name);
    }

    void Setup()
    {
        // 背景をロードして配置
        CreateBackground();

        // 敵キャラクターのロードして配置
        CreateEnemy();

        // 味方キャラクターのロードして配置

        // UIの初期化

        // 準備が整ったらバトルスタート
    }

    void CreateBackground()
    {
        // 一旦はバトルはリストの0番目のみ
        GameObject bg = Resources.Load(model_.BattleInfo.BattleInfoList[0].background_prefab_) as GameObject;
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

    }
}
