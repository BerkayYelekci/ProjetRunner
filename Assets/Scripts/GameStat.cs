using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStat : MonoBehaviour
{
    public static GameStat Instance { get { return instance; } }
    private static GameStat instance;


    public int totalFish;
    public int fishCollectedThisSession=0;

    public Action <int> OnCollectFish;


    private void Awake()
    {
        instance = this;
    }
    public void CollectFish()
    {
        fishCollectedThisSession++;
        OnCollectFish?.Invoke(fishCollectedThisSession);
    }

    public void ResetSession()
    {
        fishCollectedThisSession = 0;
        OnCollectFish?.Invoke(fishCollectedThisSession);
    }

}
