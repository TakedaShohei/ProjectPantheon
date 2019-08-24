using UnityEngine;
using System.Collections;

public class SelectStageScene : MonoBehaviour
{
    [SerializeField]GameObject canvas_ = null; 
    // Use this for initialization
    void Start()
    {
        Init(); 
    }

    void Init()
    {
        GameObject button_prefab = Resources.Load("Prefab/SelectStage/SelectStageButton") as GameObject;
        StageInfo stage_info = Resources.Load("ScriptableObject/StageInfo") as StageInfo;
        
        for(var i=0; i< stage_info.StageInfoList.Count; i++)
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
