using UnityEngine;

namespace VRPhysicsLab.Physics
{
    /// <summary>
    /// Visualizes force vectors as 3D arrows in VR.
    /// Helps students see the direction and magnitude of forces.
    /// </summary>
    public class ForceArrowVisualizer : MonoBehaviour
    {
        [Header("Arrow Settings")]
        [SerializeField] private GameObject _arrowPrefab;
        [SerializeField] private float _arrowScale = 0.1f;
        [SerializeField] private float _displayDuration = 2f;
        [SerializeField] private Gradient _forceColorGradient;

        private GameObject _currentArrow;
        private float _hideTimer;

        private void Update()
        {
            if (_currentArrow != null && _currentArrow.activeSelf)
            {
                _hideTimer -= Time.deltaTime;
                if (_hideTimer <= 0f)
                    _currentArrow.SetActive(false);
            }
        }

        /// <summary>
        /// Display a force arrow at a position.
        /// Arrow length is proportional to force magnitude.
        /// </summary>
        public void ShowForce(Vector3 position, Vector3 direction, float magnitude)
        {
            if (_arrowPrefab == null) return;

            if (_currentArrow == null)
                _currentArrow = Instantiate(_arrowPrefab);

            _currentArrow.SetActive(true);
            _currentArrow.transform.position = position;
            _currentArrow.transform.rotation = Quaternion.LookRotation(direction);
            _currentArrow.transform.localScale = Vector3.one * (magnitude * _arrowScale);

            _hideTimer = _displayDuration;
        }

        public void HideForce()
        {
            if (_currentArrow != null)
                _currentArrow.SetActive(false);
        }
    }
}
