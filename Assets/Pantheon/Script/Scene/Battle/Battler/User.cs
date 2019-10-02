using UnityEngine;
using System.Collections;

public class User : BattlerBase
{
    public User(PlayerModel model)
    {
        hp_ = model.Hp;
    }
}
