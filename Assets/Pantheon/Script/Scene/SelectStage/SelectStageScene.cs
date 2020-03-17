using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

public class SelectStageScene : MonoBehaviour, ISceneWasLoaded
{
    [SerializeField]GameObject canvas_=null;
    StageInfo stage_info_ = null;

    int chapter_id_ = 1;
    int clear_stage_id_ = 0;

    public void OnSceneWasLoaded(object[] arguments)
    {
        if(arguments == null|| arguments.Length == 0)
        {
            return;
        }
        Debug.LogFormat("SelectStageScene.OnSceneWasLoaded argument:{0}", arguments[0]);
        chapter_id_ = (int)arguments[0];

        // 前のシーンがbバトルクリアの場合
        if (arguments.Length > 1)
        {
            clear_stage_id_ = (int)arguments[1];
        }
        
        Debug.LogFormat("chapter_id_:{0}", chapter_id_);
    }

    // Use this for initialization
    void Start()
    {
        stage_info_ = Resources.Load("ScriptableObject/Stage/StageInfo" + chapter_id_) as StageInfo;
        // チャプターの最後までクリアした場合
        if (stage_info_.StageInfoList.Count <= clear_stage_id_)
        {
            chapter_id_++;
            stage_info_ = Resources.Load("ScriptableObject/Stage/StageInfo" + chapter_id_) as StageInfo;
        }
        Init();
    }

    public void Init()
    {
        GameObject button_prefab = Resources.Load("Prefab/SelectStage/SelectStageButton") as GameObject;
        //StageInfo stage_info = Resources.Load("ScriptableObject/StageInfo") as StageInfo;

        // 最新のチャプターとステージを取得
        int last_chpater_id = PlayerPrefs.GetInt("last_clear_chapter");
        int last_clear_stage_id = PlayerPrefs.GetInt("last_clear_stage");
        
        // チャプターが保存されてない場合
        if (last_chpater_id == 0) last_chpater_id = 1;

        for (int i =0; i< stage_info_.StageInfoList.Count; i++)
        {
            // 最新のチャプターの場合はクリアしてないステージはボタンを表示しない
            if(chapter_id_ == last_chpater_id)
            {
                if (i > last_clear_stage_id) break;
            }
            
            GameObject button = Instantiate(button_prefab, canvas_.transform);
            button.transform.position = new Vector3(0, i * -1, 0);
            SelectStageButton select_button = button.GetComponent<SelectStageButton>();
            select_button.SetUp(chapter_id_, stage_info_.StageInfoList[i]);
            
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
