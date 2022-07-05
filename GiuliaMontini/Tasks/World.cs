using System.Drawing;

namespace Tasks
{
    /// <summary>
    /// The class that manage the game's world.
    /// </summary>
    public class World
    {
        /// <summary>
        /// Represent List of GameMap
        /// </summary>
        public List<List<Rectangle>>? Maps { get; set; }
        /// <summary>
        /// Represent the current GameMap
        /// </summary>
        public List<Rectangle>? CurrentMap { get; set; }
        /// <summary>
        /// Represent Player class
        /// </summary>
        private Rectangle _player;

        public World()
        {
            Maps = new List<List<Rectangle>>() { new() { Rectangle.Empty } };
            CurrentMap = Maps[0];
        }

        /// <summary>
        /// Return the player.
        /// </summary>
        /// <returns>A Rectangle that represent the Player</returns>
        public Rectangle GetPlayer()
        {
            return _player;
        }

        /// <summary>
        /// Set the player.
        /// </summary>
        /// <param name="player"> the Rectangle that represent</param>
        public void SetPlayer(Rectangle player)
        {
            _player = player;
        }


        /// <summary>
        ///  Update the world's state.
        /// </summary>
        /// <param name="lastDirection">Represents Player's lastDirection</param>
        /// <param name="isIdle">Represents Player's isIdle</param>
        /// <param name="physicsComponent">Represents Player's PhysicsComponent</param>
        public void UpdateState(Direction lastDirection, bool isIdle, IPhysicsComponent physicsComponent)
        {
            if (PlayerCollide(lastDirection) == null)
            {
                physicsComponent.Update(ref _player, lastDirection, isIdle);
            }
        }

        /// <summary>
        ///  Method to check the player's collision.
        /// </summary>
        /// <param name="lastDirection">Represents Player's lastDirection</param>
        /// <returns></returns>
        public Rectangle? PlayerCollide(Direction lastDirection) {
            Point playerPos = _player.Location;
            List<Rectangle> control = new();
            Rectangle playerHitbox = _player;
            switch (lastDirection)
            {
                case Direction.Up:
                    control = CurrentMap.Where(b => b.Location.Y < _player.Location.Y).ToList();
                    playerHitbox.Location = new(playerPos.X, playerPos.Y - 2);
                    break;
                case Direction.Down:
                    control = CurrentMap.Where(b => b.Location.Y > _player.Location.Y).ToList();
                    playerHitbox.Location = new(playerPos.X, playerPos.Y + 2);
                    break;
                case Direction.Left:
                    control = CurrentMap.Where(b => b.Location.X < _player.Location.X).ToList();
                    playerHitbox.Location = new (playerPos.X - 2, playerPos.Y);
                    break;
                case Direction.Right:
                    control = CurrentMap.Where(b => b.Location.X > _player.Location.X).ToList();
                    playerHitbox.Location = new(playerPos.X + 2, playerPos.Y);
                    break;
                default:
                    break;
            }
            foreach ( Rectangle b in control)
            {
                if (playerHitbox.IntersectsWith(b))
                {
                    return b;
                }
            }
            return null;
        }
    }
}
