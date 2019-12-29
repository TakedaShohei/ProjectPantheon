using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class SkillSetUI : MonoBehaviour
{
    //スキル所持
    [SerializeField] Image skill_image_=null;
    [SerializeField] TextMeshProUGUI skill_tittle_=null;
    [SerializeField] TextMeshProUGUI skill_explain_=null;
    [SerializeField] TextMeshProUGUI skill_number_=null;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Setup(SkillInfo skill_info)
    {
        Debug.Log(skill_info.Name);
        skill_tittle_.text = skill_info.Name;
        skill_number_.text = skill_info.IdNumber.ToString();
        skill_explain_.text = skill_info.Explain;
        
    }
}
