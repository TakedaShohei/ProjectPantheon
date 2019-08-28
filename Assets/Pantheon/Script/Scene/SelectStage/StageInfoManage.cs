using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;



public class StageInfoManage : MonoBehaviour
{

    StageModel model_ = null;

    public void LoadingStageScene()
    {
        Debug.Log("Stage");
        StageInfo stage_info = Resources.Load("ScriptableObject/StageInfo") as StageInfo;
        int id = stage_info.StageInfoList.Count;
        Debug.Log("Stage" + id);
        SceneManager.LoadScene(sceneName:"Stage" + id);
        
    }
}