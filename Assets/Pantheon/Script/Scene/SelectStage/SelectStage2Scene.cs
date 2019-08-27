using UnityEngine;
using UnityEditor;

public class SelectStage2Scene : MonoBehaviour
{
    [SerializeField] GameObject canvas_ = null;
    // Use this for initialization
    void Start()
    {

    }

    public void Init()
    {
        GameObject button_prefab = Resources.Load("Prefab/SelectStage/SelectStageButton") as GameObject;
        StageInfo stage_info = Resources.Load("ScriptableObject/Stage2") as StageInfo;
        for (int i = 0; i < stage_info.StageInfoList.Count; i++)
        {
            Debug.Log("test" + i);
            GameObject button = Instantiate(button_prefab, canvas_.transform);
            button.transform.position = new Vector3(0, i * -1, 0);
            SelectStageButton select_button = button.GetComponent<SelectStageButton>();
            select_button.SetUp(stage_info.StageInfoList[i]);
        }

    }
}