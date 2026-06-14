using UnityEngine;

namespace VRPhysicsLab.Core
{
    /// <summary>
    /// Central game manager. Handles application lifecycle and global state.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [Header("Settings")]
        [SerializeField] private bool _debugMode = false;

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

        private void Start()
        {
            Application.targetFrameRate = 72; // Meta Quest 3 target
            if (_debugMode)
                Debug.Log("[GameManager] Initialized in debug mode.");
        }

        public void QuitApplication()
        {
            Application.Quit();
        }
    }
}
