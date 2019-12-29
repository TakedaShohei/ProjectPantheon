using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class SkillListUI : MonoBehaviour
{
    [SerializeField] SkillInfo skill_;
    [SerializeField] GameObject skill_list;

  

    [SerializeField]PlayerInfo play_info;

    public void SetActive()
    {
        skill_list.SetActive(!skill_list.activeSelf);

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
