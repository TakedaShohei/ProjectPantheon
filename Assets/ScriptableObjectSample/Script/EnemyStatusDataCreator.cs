using UnityEngine;
using UnityEditor;

public class EnemyStatusDataCreator : ScriptableObject
{
    [MenuItem("Create/EnemyStatusData")]
    private static void Create()
    {
        //ScriptableObjectのインスタンスを作成
        EnemyStatusData enemyStatusData = ScriptableObject.CreateInstance<EnemyStatusData>();

        //データを設定
        EnemyStatus status1 = new EnemyStatus(), status2 = new EnemyStatus();
        status1.Name = "リオレウス";
        status2.Name = "リオレイア";

        enemyStatusData.EnemyStatusList.Add(status1);
        enemyStatusData.EnemyStatusList.Add(status2);

        //ファイル書き出し
        AssetDatabase.CreateAsset(enemyStatusData, "Assets/EnemyStatusData.asset");
    }
}