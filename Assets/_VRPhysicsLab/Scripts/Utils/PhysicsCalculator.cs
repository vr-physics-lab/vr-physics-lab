namespace VRPhysicsLab.Utils
{
    /// <summary>
    /// Utility class with common physics formulas used across experiments.
    /// </summary>
    public static class PhysicsCalculator
    {
        // Constants
        public const float GRAVITY_EARTH  = 9.81f;
        public const float GRAVITY_MOON   = 1.62f;
        public const float GRAVITY_MARS   = 3.72f;
        public const float GRAVITY_JUPITER = 24.79f;

        /// <summary>F = m * a</summary>
        public static float Force(float mass, float acceleration) => mass * acceleration;

        /// <summary>a = F / m</summary>
        public static float Acceleration(float force, float mass) => mass != 0 ? force / mass : 0f;

        /// <summary>KE = 0.5 * m * v^2</summary>
        public static float KineticEnergy(float mass, float velocity) => 0.5f * mass * velocity * velocity;

        /// <summary>PE = m * g * h</summary>
        public static float PotentialEnergy(float mass, float height, float gravity = GRAVITY_EARTH)
            => mass * gravity * height;

        /// <summary>p = m * v (momentum)</summary>
        public static float Momentum(float mass, float velocity) => mass * velocity;

        /// <summary>Free fall time: t = sqrt(2h / g)</summary>
        public static float FreeFallTime(float height, float gravity = GRAVITY_EARTH)
            => gravity > 0 ? UnityEngine.Mathf.Sqrt(2f * height / gravity) : 0f;

        /// <summary>Velocity after free fall: v = sqrt(2 * g * h)</summary>
        public static float FreeFallVelocity(float height, float gravity = GRAVITY_EARTH)
            => UnityEngine.Mathf.Sqrt(2f * gravity * height);
    }
}
