using UnityEngine;
using VRPhysicsLab.Core;
using VRPhysicsLab.Physics;

namespace VRPhysicsLab.Experiments.NewtonLaws
{
    /// <summary>
    /// Newton's Laws of Motion experiment.
    /// Students can apply forces to objects and observe F = ma in action.
    /// </summary>
    public class NewtonLawsExperiment : ExperimentBase
    {
        [Header("Experiment Objects")]
        [SerializeField] private PhysicsObject[] _experimentObjects;
        [SerializeField] private ForceArrowVisualizer _forceVisualizer;

        [Header("Force Settings")]
        [SerializeField] private float _appliedForce = 10f;
        [SerializeField] private Vector3 _forceDirection = Vector3.forward;

        [Header("UI")]
        [SerializeField] private NewtonLawsUI _ui;

        protected override void OnExperimentStart()
        {
            ResetObjectPositions();
            _ui?.UpdateDisplay(0f, 0f, 0f);
        }

        protected override void OnExperimentReset()
        {
            ResetObjectPositions();
            _ui?.UpdateDisplay(0f, 0f, 0f);
        }

        /// <summary>
        /// Apply force to a specific physics object.
        /// Demonstrates F = ma: a = F/m
        /// </summary>
        public void ApplyForceToObject(int objectIndex)
        {
            if (objectIndex < 0 || objectIndex >= _experimentObjects.Length) return;

            var obj = _experimentObjects[objectIndex];
            obj.ApplyForce(_forceDirection * _appliedForce);

            float acceleration = _appliedForce / obj.Mass;
            _ui?.UpdateDisplay(_appliedForce, obj.Mass, acceleration);
            _forceVisualizer?.ShowForce(obj.transform.position, _forceDirection, _appliedForce);

            Debug.Log($"[Newton] F={_appliedForce}N, m={obj.Mass}kg, a={acceleration:F2}m/s²");
        }

        private void ResetObjectPositions()
        {
            foreach (var obj in _experimentObjects)
                obj?.ResetToInitialState();
        }
    }
}
