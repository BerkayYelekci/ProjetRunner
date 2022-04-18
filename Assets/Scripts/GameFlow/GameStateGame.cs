using UnityEngine;
using TMPro;
using System;

public class GameStateGame : GameState
{
    public GameObject gameUI;
    [SerializeField] private TextMeshProUGUI fishCountText;

    public override void Construct()
    {
        GameManager.Instance.motor.ResumePlayer();
        
        GameManager.Instance.ChangeCamera(GameCamera.Game);

        GameStat.Instance.OnCollectFish += OnCollectFish;

        gameUI.SetActive(true);

    }

    private void OnCollectFish(int amnCollected)
    {
        fishCountText.text ="Fish : "+ amnCollected.ToString();
    }

    public override void Destruct()
    {
        gameUI.SetActive(false);

        GameStat.Instance.OnCollectFish -= OnCollectFish;
    }

}

