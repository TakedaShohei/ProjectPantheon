using UnityEngine;
using TMPro;

public class SelectStageButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_ = null;
    StageModel model_ = null;


    public void SetUp(StageModel model)
    {
        model_ = model;
        text_.text = model_.Name;

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
