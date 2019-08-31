using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SelectStageButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_ = null;
    StageModel model_ = null;


    public void SetUp(StageModel model)
    {
        model_ = model;
        text_.text = model_.Name;

    }

    public void OnClick()
    {
        Debug.Log("Battle　" + model_.Id);
        SceneManagerEx.LoadSceneWithArg("Battle", model_, LoadSceneMode.Single);

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
