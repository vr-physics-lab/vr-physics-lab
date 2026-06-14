using UnityEngine;
using TMPro;

namespace VRPhysicsLab.UI
{
    /// <summary>
    /// In-VR UI panel for Newton's Laws experiment.
    /// Displays real-time Force, Mass, and Acceleration values.
    /// </summary>
    public class NewtonLawsUI : MonoBehaviour
    {
        [Header("Display Fields")]
        [SerializeField] private TextMeshProUGUI _forceText;
        [SerializeField] private TextMeshProUGUI _massText;
        [SerializeField] private TextMeshProUGUI _accelerationText;
        [SerializeField] private TextMeshProUGUI _formulaText;

        private void Start()
        {
            UpdateDisplay(0f, 1f, 0f);
        }

        /// <summary>
        /// Update the UI with current physics values.
        /// </summary>
        public void UpdateDisplay(float force, float mass, float acceleration)
        {
            if (_forceText) _forceText.text = $"F = {force:F1} N";
            if (_massText) _massText.text = $"m = {mass:F1} kg";
            if (_accelerationText) _accelerationText.text = $"a = {acceleration:F2} m/s²";
            if (_formulaText) _formulaText.text = $"F = m × a\n{force:F1} = {mass:F1} × {acceleration:F2}";
        }
    }
}
