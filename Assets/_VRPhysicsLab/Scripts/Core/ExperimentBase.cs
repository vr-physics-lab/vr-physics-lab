using UnityEngine;

namespace VRPhysicsLab.Core
{
    /// <summary>
    /// Abstract base class for all physics experiments.
    /// Inherit from this to create new experiments.
    /// </summary>
    public abstract class ExperimentBase : MonoBehaviour
    {
        [Header("Experiment Info")]
        [SerializeField] private string _experimentName = "Unnamed Experiment";
        [SerializeField] [TextArea] private string _description = "";

        public string ExperimentName => _experimentName;
        public string Description => _description;

        public bool IsRunning { get; private set; }

        protected virtual void Start()
        {
            if (ExperimentManager.Instance != null)
                ExperimentManager.Instance.RegisterExperiment(this);
        }

        /// <summary>Starts the experiment.</summary>
        public virtual void StartExperiment()
        {
            IsRunning = true;
            OnExperimentStart();
            Debug.Log($"[{_experimentName}] Started.");
        }

        /// <summary>Resets the experiment to initial state.</summary>
        public virtual void ResetExperiment()
        {
            IsRunning = false;
            OnExperimentReset();
            Debug.Log($"[{_experimentName}] Reset.");
        }

        /// <summary>Override to implement experiment start logic.</summary>
        protected abstract void OnExperimentStart();

        /// <summary>Override to implement experiment reset logic.</summary>
        protected abstract void OnExperimentReset();
    }
}
