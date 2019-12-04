using UnityEngine;
using System.Collections;
using System;

public class VisualNovelScene : MonoBehaviour, ISceneWasLoaded
{
    [SerializeField]VisualNovelSystem novel_system_ = null;
    StageModel stage_model_ = null;
    
    public void OnSceneWasLoaded(object[] arguments)
    {
        //Debug.LogFormat("VisualNovelScene OnSceneWasLoaded arguments[0]:{0}", arguments[0]);
        stage_model_ = arguments[0] as StageModel;
    }

    // Use this for initialization
    void Start()
    {
        novel_system_.SetUp(stage_model_);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
