using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainStoryScene : MonoBehaviour
{

    public void LoadSelectStageScene(int id)
    {
        Debug.LogFormat("MainStoryScene id:{0}", id);
        SceneManagerEx.LoadSceneWithArg("SelectStage", new object[] { id }, LoadSceneMode.Single);
    }

    // Use this for initialization
    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
