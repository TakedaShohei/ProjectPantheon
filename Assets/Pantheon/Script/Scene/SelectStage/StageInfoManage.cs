using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;



public class StageInfoManage : MonoBehaviour
{

    StageModel model_ = null;

    public void LoadingStageScene()
    {

        int id = model_.Id;

        SceneManager.LoadScene("Stage"+id);
    }
}