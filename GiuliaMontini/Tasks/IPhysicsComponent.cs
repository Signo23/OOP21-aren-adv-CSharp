using System.Drawing;

namespace Tasks
{
    /// <summary>
    /// A component for physics.
    /// </summary>
    public interface IPhysicsComponent
    {
        /// <summary>
        /// Update the BaseEntity.
        /// </summary>
        /// <param name="entity"> the <see cref="Rectangle"/> to update istaed of BaseEntity</param>
        /// <param name="lastDirection"> the  <see cref="Direction"/> for simulate player's lastDirection </param>
        /// <param name="isIdle"> the boolean to simulate Player's isIdle</param>
        void Update(ref Rectangle entity, Direction lastDirection, bool isIdle);
    }
}
