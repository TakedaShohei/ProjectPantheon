using UnityEngine;
using System.Collections;

public class AttackDemo : MonoBehaviour
{
    public int hp = 100;
    public int attack = 10;
    public GameObject gb;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DestroyDemo()
    {
        hp = hp - attack;
        if(hp == 0)
        {
            Destroy(gb);
        }
    }
}
