using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattlerBase : MonoBehaviour
{
    public enum ActionState
    {
        Wait,
        Ready,
        Action,
        Dead
    }

    public int hp_;
    public int attack_;
    public int defence_;

    public int Speed { get; set; } = 0;

    HPGauge hp_gauge_ = null;
    public HPGauge Hpgauge
    {
        get { return hp_gauge_; }
        set { hp_gauge_ = value; }
    }

    System.Action attack_impact_ = null;
    public System.Action AttackImpact
    {
        get { return attack_impact_; }
        set { attack_impact_ = value; }
    }

    System.Action attack_impact2_ = null;
    public System.Action AttackImpact2
    {
        get { return attack_impact2_; }
        set { attack_impact2_ = value; }
    }

    System.Action attack_back_ = null;
    public System.Action AttackBack
    {
        get { return attack_back_; }
        set { attack_back_ = value; }
    }

    ParticleSystem particle_effect_ = null;
    public ParticleSystem Particle
    {
        get { return particle_effect_; }
        set { particle_effect_ = value; }
    }

    GameObject game_object_ = null;
    public GameObject GameObjectBattler
    {
        get { return game_object_; }
        set { game_object_ = value; }
    }

    ActionState state_;
    public ActionState State
    {
        get { return state_; }
        set { state_ = value; }
    }

    Animator animator_ = null;
    public Animator Animator
    {
        get { return animator_; }
        protected set { animator_ = value; }
    }

    [SerializeField] Transform move_transform_ = null;
    public Transform MoveTransform
    {
        set { move_transform_ = value; }
    }

    [SerializeField] Transform effect_transform_ = null;
    public Transform EffectTransform
    {
        get { return effect_transform_; }
        set { effect_transform_ = value; }
    }
    [SerializeField] ParticleSystem effect_particle_ = null;
    public ParticleSystem EffectParticle
    {
        get { return effect_particle_; }
        set { effect_particle_ = value; }
    }

    Vector3 targe_pos_;
    Vector3 base_pos_;

    protected void Setup()
    {
        animator_ = game_object_.GetComponent<Animator>();
        base_pos_ = move_transform_.position;
        targe_pos_ = move_transform_.position;

       
    }

    public void Die()
    {
        state_ = ActionState.Dead;
        DieEffect();
        
    }

    public virtual void DieEffect()
    {

    }

    public void AnimationAttackImpact()
    {
        if (attack_impact_ != null) attack_impact_();
    }

    public void AnimationAttackImpact2()
    {
        if (attack_impact2_ != null) attack_impact2_();
    }

    public void AnimationAttackBack()
    {
        if (attack_back_ != null) attack_back_();
    }

    public void Move(Vector3 add_pos)
    {
        if (move_transform_ == null) return;
        targe_pos_ = base_pos_ + add_pos;
    }

    private void Update()
    {
        if (targe_pos_ != move_transform_.position)
        {
            move_transform_.position += (targe_pos_ - move_transform_.position) / 10;
        }
    }

    /*public void UpdateStaus()
    {
        List<ActionState> action_state_list = new System.Collections.Generic.List<ActionState>();
        //  ActionState state_ = ActionState.Wait;
        foreach (ActionState state_ in action_state_list)
        {



            if (state_ == ActionState.Dead)
            {


                break;

            }
        }
        
    }*/
}
