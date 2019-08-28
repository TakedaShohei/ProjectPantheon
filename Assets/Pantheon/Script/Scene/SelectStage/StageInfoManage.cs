using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;



public class StageInfoManage : MonoBehaviour
{

    StageModel model_ = null;

    public void LoadingStageScene(StageModel model)
    {
        model_ = model;
        int id = model_.Id;
        Debug.Log("Stage" + id);
        SceneManager.LoadScene("Stage"+id);
        
    }
}