using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleClearUI : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadingSelectStage()
    {
        SceneManagerEx.LoadSceneWithArg("SelectStage", new object[] { BattleData.StageModel.ChapterId, BattleData.StageModel.Id }, LoadSceneMode.Single);

    }

    public void Indicate()
    {
        this.gameObject.SetActive(true);

        //クリアしたデータを保存

        //　チャプターが以前より新しい場合
        if(PlayerPrefs.GetInt("last_clear_chapter") < BattleData.StageModel.ChapterId)
        {
            PlayerPrefs.SetInt("last_clear_chapter", BattleData.StageModel.ChapterId);
            PlayerPrefs.SetInt("last_clear_stage", BattleData.StageModel.Id);
        }

        // チャプターが以前と同じ場合
        if (PlayerPrefs.GetInt("last_clear_chapter") == BattleData.StageModel.ChapterId)
        {
            // ステージが以前より新しい場合
            if (PlayerPrefs.GetInt("last_clear_stage") < BattleData.StageModel.Id)
            {
                PlayerPrefs.SetInt("last_clear_stage", BattleData.StageModel.Id);
            }    
        }
    }
}
