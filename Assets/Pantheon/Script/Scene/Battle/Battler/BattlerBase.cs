using UnityEngine;
using System.Collections;

public class BattlerBase
{
    public enum ActionState
    {
        Wait,
        Ready,
        Action
    }

    public int hp_;
    public int attack_;
    public int defence_;

    ActionState state_;
    public ActionState State
    {
        get { return state_; }
    }
}
