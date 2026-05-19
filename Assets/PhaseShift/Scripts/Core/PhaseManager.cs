using System;
using PhaseShift.Configs;
using UnityEngine;
using static IdaelDev.AdvancedLogger.Log;

namespace PhaseShift.Core
{
    public class PhaseManager
    {
        public enum WorldPhase{Real, Spectral}
        public WorldPhase CurrentPhase { get; private set; } = WorldPhase.Real;

        public static event Action<WorldPhase> OnPhaseChanged;

        private GameSettings _gameSettings;
        private float _lastSwitchTime = -999;

#region Constructors

        public PhaseManager(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            Debug("Phase Manager Initialized");
        }

#endregion

#region Public

        public void TogglePhase()
        {
            if (Time.time - _lastSwitchTime < _gameSettings.SwitchCooldown) return;

            CurrentPhase = CurrentPhase == WorldPhase.Real
                ? WorldPhase.Spectral
                : WorldPhase.Real;

            _lastSwitchTime = Time.time;
            Info("Phase changed to " + CurrentPhase);
            OnPhaseChanged?.Invoke(CurrentPhase);
        }

        public bool IsReal => CurrentPhase == WorldPhase.Real;
        public bool IsSpectral => CurrentPhase == WorldPhase.Spectral;

#endregion
    }

}
