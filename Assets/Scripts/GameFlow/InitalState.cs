using UnityEngine;
using TMPro;

public class InitalState : GameState
{
    public GameObject menuUI;
    [SerializeField] private TextMeshProUGUI fishCountText;

    public override void Construct()
    {
        GameManager.Instance.ChangeCamera(GameCamera.Init);
       // fishCountText.text = "Fish : " + "TBD";
        menuUI.SetActive(true);
    }

    public override void Destruct()
    {
        menuUI.SetActive(false);
    }



    public void OnPlayClick()
    {
        brain.ChangeState(GetComponent<GameStateGame>());
        
        GameStat.Instance.ResetSession();
    }


}
