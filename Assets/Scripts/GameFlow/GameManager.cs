using UnityEngine;

public enum GameCamera
{
    Init=0,
    Game=1,
    Respawn=2,
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get { return instance; } }
    private static GameManager instance;

    public PlayerMotor motor;
    public GameObject[] cameras;


    private GameState state;

    private void Awake()
    {
        instance = this;
        state = GetComponent<InitalState>();
        state.Construct();
    }
    private void Update()
    {
        state.UpdateState();
    }
    public void ChangeState(GameState s)
    {
        state.Destruct();
        state = s;
        state.Construct();
    }

    public void ChangeCamera(GameCamera c)
    {
        foreach (GameObject go in cameras)
            go.SetActive(false);

        cameras[(int)c].SetActive(true);
    }
}
