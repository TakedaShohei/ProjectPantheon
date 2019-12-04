using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SelectStageButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_ = null;
    StageModel model_ = null;
    int chapter_id_ = 0;


    public void SetUp(int chapter_id, StageModel model)
    {
        chapter_id_ = chapter_id;
        model_ = model;
        text_.text = model_.Name;

    }

    public void OnClick()
    {
        Debug.LogFormat("SelectStageButton.OnClick id:{0}", model_.Id);
        SceneManagerEx.LoadSceneWithArg("VisualNovel", new object[] { model_ }, LoadSceneMode.Single);
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
