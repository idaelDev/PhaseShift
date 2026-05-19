using IdaelDev.DependencyInjection;
using PhaseShift;
using PhaseShift.Core;
using UnityEngine;
using UnityEngine.InputSystem;

public class SetupTest : MonoBehaviour
{
    private PhaseShiftControls _controls;

    [Inject] private PhaseManager _phaseManager;

    private void Awake()
    {
        _controls = new PhaseShiftControls();
        _controls.Player.PhaseShift.performed += _ => _phaseManager.TogglePhase();
    }

    private void OnEnable()  => _controls.Enable();
    private void OnDisable() => _controls.Disable();
}
