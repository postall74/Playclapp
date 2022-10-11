using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private GameObject _finish;

    private Spawner _spawner;
    private InputManager _inputManager;

    public void OnSpeed()
    {
        _cube.GetComponent<Cube>().SetSpeed(_inputManager.GetSpeed());
    }

    public void OnPosition()
    {
        _finish.transform.position = new Vector3(_inputManager.GetPositionX(), _inputManager.GetPositionY(), _inputManager.GetPositionZ());
    }

    public void OnTimeSpawn()
    {
        _spawner.SetTimeSpawn(_inputManager.GetTimeSpawn());
    }

    private void Start()
    {
        _spawner = GetComponent<Spawner>();
        _inputManager = GetComponent<InputManager>();
    }
}
