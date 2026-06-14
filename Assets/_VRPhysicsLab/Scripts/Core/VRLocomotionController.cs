using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace VRPhysicsLab.Core
{
    /// <summary>
    /// Handles VR locomotion for Meta Quest 3.
    /// Supports both teleport and smooth movement.
    /// </summary>
    public class VRLocomotionController : MonoBehaviour
    {
        public enum LocomotionMode { Teleport, SmoothMove }

        [Header("Locomotion Settings")]
        [SerializeField] private LocomotionMode _mode = LocomotionMode.Teleport;
        [SerializeField] private float _moveSpeed = 2f;
        [SerializeField] private float _turnSpeed = 60f;

        [Header("References")]
        [SerializeField] private ActionBasedContinuousMoveProvider _smoothMoveProvider;
        [SerializeField] private ActionBasedSnapTurnProvider _snapTurnProvider;
        [SerializeField] private TeleportationProvider _teleportProvider;

        private void Start()
        {
            SetLocomotionMode(_mode);
        }

        /// <summary>Switch between teleport and smooth movement.</summary>
        public void SetLocomotionMode(LocomotionMode mode)
        {
            _mode = mode;
            bool smooth = mode == LocomotionMode.SmoothMove;

            if (_smoothMoveProvider) _smoothMoveProvider.enabled = smooth;
            if (_teleportProvider) _teleportProvider.enabled = !smooth;

            Debug.Log($"[Locomotion] Mode set to: {mode}");
        }
    }
}
