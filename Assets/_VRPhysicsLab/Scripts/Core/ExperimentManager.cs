using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRPhysicsLab.Core
{
    /// <summary>
    /// Manages loading, starting, and transitioning between physics experiments.
    /// </summary>
    public class ExperimentManager : MonoBehaviour
    {
        public static ExperimentManager Instance { get; private set; }

        [Header("Experiment Scenes")]
        [SerializeField] private string _mainMenuScene = "MainMenu";
        [SerializeField] private string[] _experimentScenes;

        private ExperimentBase _currentExperiment;

        public ExperimentBase CurrentExperiment => _currentExperiment;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        /// <summary>
        /// Loads an experiment scene by index.
        /// </summary>
        public void LoadExperiment(int index)
        {
            if (index < 0 || index >= _experimentScenes.Length)
            {
                Debug.LogError($"[ExperimentManager] Invalid experiment index: {index}");
                return;
            }
            SceneManager.LoadScene(_experimentScenes[index]);
        }

        /// <summary>
        /// Returns to the main menu.
        /// </summary>
        public void LoadMainMenu()
        {
            SceneManager.LoadScene(_mainMenuScene);
        }

        /// <summary>
        /// Called by experiments to register themselves.
        /// </summary>
        public void RegisterExperiment(ExperimentBase experiment)
        {
            _currentExperiment = experiment;
            Debug.Log($"[ExperimentManager] Registered experiment: {experiment.ExperimentName}");
        }
    }
}
