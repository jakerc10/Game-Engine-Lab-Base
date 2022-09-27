using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    int HP = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    public void HealthBoost(int foodValue)
    {
        HP += foodValue;
        Debug.Log(HP);
    }
}
