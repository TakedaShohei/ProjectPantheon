using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine.UI;
[CreateAssetMenu(
   fileName = "SkillInfo",
   menuName = "Pantheon/SkillInfo",
   order = 0)
]

public class SkillInfo : ScriptableObject
{
   
    [SerializeField] private string name_;
    public string Name
    {
        get { return name_; }
        protected set { name_ = value; }
    }

    [SerializeField] private int id_number_;
    public int IdNumber
    {
        get { return id_number_; }
        protected set { id_number_ = value; }
    }
    [SerializeField] private int skill_type_name_;
    public int SkillTypeName
    {
        get { return skill_type_name_; }
        protected set { skill_type_name_= value; }
    }
    [SerializeField] private float damage_value_;
    public float DamageValue
    {
        get { return damage_value_; }
        protected set { damage_value_ = value; }
    }

    [SerializeField] private string explain_;
    public string Explain
    {
        get { return explain_; }
        protected set { explain_ = value; }
    }

    [SerializeField] private Sprite skill_image_;
    public Sprite SkillImage
    {
        get { return skill_image_; }
        protected set { skill_image_ = value; }
    }

    [SerializeField] private GameObject effect_prehab_;
    public GameObject EffectPrehab
    {
        get { return effect_prehab_; }
        protected set { effect_prehab_ = value; }
    }

    [SerializeField] private string effect_transform_;
    public string EffectTransform
    {
        get { return effect_transform_; }
        protected set { effect_transform_ = value; }
    }

    [SerializeField] private int wait_turn_;
    public int WaitTurn
    {
        get { return wait_turn_; }
        protected set { wait_turn_ = value; }
    }

    private int current_wait_turn_;
    public int CurrentWaitTurn
    {
        get { return current_wait_turn_; }
        set { current_wait_turn_ = value; }
    }

}

