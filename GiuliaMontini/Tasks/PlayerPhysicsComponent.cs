using System.Drawing;

namespace Tasks
{
    public class PlayerPhysicsComponent : IPhysicsComponent
    {
        private readonly int _velocity;
        /// <summary>
        /// The physics component for Player.
        /// Implements <see cref="PhysicsComponent"/>
        /// </summary>
        public PlayerPhysicsComponent()
        {
            _velocity = 2;
        }
        public void Update(ref Rectangle @entity, Direction lastDirection, bool isIdle)
        {
            if (!isIdle)
            {
                Point currentPos = @entity.Location;
                switch (lastDirection)
                {
                    case Direction.Left:
                        @entity.Location = new (currentPos.X - _velocity, currentPos.Y);
                        break;
                    case Direction.Right:
                        @entity.Location = new (currentPos.X + _velocity, currentPos.Y);
                        break;
                    case Direction.Up:
                        @entity.Location = new (currentPos.X, currentPos.Y - _velocity);
                        break;
                    case Direction.Down:
                        @entity.Location =  new (currentPos.X, currentPos.Y + _velocity);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
