using UnityEngine;

namespace VRPhysicsLab.Physics
{
    /// <summary>
    /// A physics-enabled lab object that students can interact with.
    /// Wraps Unity's Rigidbody with educational data tracking.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class PhysicsObject : MonoBehaviour
    {
        [Header("Physical Properties")]
        [SerializeField] private float _mass = 1f;
        [SerializeField] private string _objectLabel = "Object";

        private Rigidbody _rb;
        private Vector3 _initialPosition;
        private Quaternion _initialRotation;

        // Data tracking
        public float Mass => _rb ? _rb.mass : _mass;
        public Vector3 Velocity => _rb ? _rb.linearVelocity : Vector3.zero;
        public float Speed => Velocity.magnitude;
        public float KineticEnergy => 0.5f * Mass * Speed * Speed;
        public string Label => _objectLabel;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.mass = _mass;
            _initialPosition = transform.position;
            _initialRotation = transform.rotation;
        }

        /// <summary>Apply an instantaneous force to this object.</summary>
        public void ApplyForce(Vector3 force)
        {
            _rb.AddForce(force, ForceMode.Force);
        }

        /// <summary>Apply an impulse (instant velocity change).</summary>
        public void ApplyImpulse(Vector3 impulse)
        {
            _rb.AddForce(impulse, ForceMode.Impulse);
        }

        /// <summary>Reset object to its initial position and stop all motion.</summary>
        public void ResetToInitialState()
        {
            transform.position = _initialPosition;
            transform.rotation = _initialRotation;
            _rb.linearVelocity = Vector3.zero;
            _rb.angularVelocity = Vector3.zero;
        }

        /// <summary>Set object mass at runtime (for experiments).</summary>
        public void SetMass(float mass)
        {
            _mass = mass;
            _rb.mass = mass;
        }
    }
}
