using UnityEngine;

namespace PhaseShift.Configs
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "Scriptable Objects/GameSettings")]
    public class GameSettings : ScriptableObject
    {
        [SerializeField]  public readonly float SwitchCooldown = 0.8f;
    }
}
