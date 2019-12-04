using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

public class SelectStageScene : MonoBehaviour, ISceneWasLoaded
{
    [SerializeField]GameObject canvas_=null;
    StageInfo stage_info_ = null;

    int chapter_id_ = 0;

    public void OnSceneWasLoaded(object[] arguments)
    {
        Debug.LogFormat("SelectStageScene.OnSceneWasLoaded argument:{0}", arguments[0]);
        chapter_id_ = (int)arguments[0];
        Debug.LogFormat("chapter_id_:{0}", chapter_id_);
    }

    // Use this for initialization
    void Start()
    {
        stage_info_ = Resources.Load("ScriptableObject/Stage/StageInfo" + chapter_id_) as StageInfo;
        Init();
    }

    public void Init()
    {
        GameObject button_prefab = Resources.Load("Prefab/SelectStage/SelectStageButton") as GameObject;
        //StageInfo stage_info = Resources.Load("ScriptableObject/StageInfo") as StageInfo;
        
        for(int i =0; i< stage_info_.StageInfoList.Count; i++)
        {
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
