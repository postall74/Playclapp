using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] private InputField _speed;
    [SerializeField] private InputField _positionX;
    [SerializeField] private InputField _positionY;
    [SerializeField] private InputField _positionZ;
    [SerializeField] private InputField _timeSpawn;

    public float GetSpeed()
    {
        decimal.TryParse(_speed.text, out decimal value);
        return (float)value;
    }

    public float GetPositionX()
    {
        decimal.TryParse(_positionX.text, out decimal value);
        return (float)value;
    }

    public float GetPositionY()
    {
        decimal.TryParse(_positionY.text, out decimal value);
        return (float)value;
    }


    public float GetPositionZ()
    {
        decimal.TryParse(_positionZ.text, out decimal value);
        return (float)value;
    }

    public float GetTimeSpawn()
    {
        decimal.TryParse(_timeSpawn.text, out decimal value);
        return (float)value;
    }
}
