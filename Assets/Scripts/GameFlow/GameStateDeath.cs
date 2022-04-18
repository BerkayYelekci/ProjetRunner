public class GameStateDeath : GameState
{
    public override void Construct()
    {
        GameManager.Instance.motor.PausePlayer();
    }

    public override void UpdateState()
    {
        if (InputManager.Instance.Tap)
            ResumeGame();
    }
    public void ResumeGame()
    {
        GameManager.Instance.motor.RespawnPlayer();
        brain.ChangeState(GetComponent<GameStateGame>());
        GameStat.Instance.ResetSession();
    }
}
