using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

public class SelectStageScene : MonoBehaviour, ISceneWasLoaded
{
    [SerializeField]GameObject canvas_=null;
    public StageInfo stage;
    public void OnSceneWasLoaded(object argument)
    {
        Debug.Log("OnSceneWasLoaded.");
    }

    // Use this for initialization
    void Start()
    {
       
    }

    public void Init()
    {
        GameObject button_prefab = Resources.Load("Prefab/SelectStage/SelectStageButton") as GameObject;
        StageInfo stage_info = Resources.Load("ScriptableObject/StageInfo") as StageInfo;
        
        for(int i =0; i< stage_info.StageInfoList.Count; i++)
        {
            GameObject button = Instantiate(button_prefab, canvas_.transform);
            button.transform.position = new Vector3(0, i * -1, 0);
            SelectStageButton select_button = button.GetComponent<SelectStageButton>();
            select_button.SetUp(stage_info.StageInfoList[i]);
            
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
