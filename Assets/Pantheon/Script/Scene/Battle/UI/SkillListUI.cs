using UnityEngine;
using System.Collections;

public class SkillListUI : MonoBehaviour
{
    public GameObject skill_list;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetActive()
    {
        skill_list.SetActive(!skill_list.activeSelf);
        
    }
}
