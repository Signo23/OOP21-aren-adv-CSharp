namespace Tasks
{
    ///<summary>
    ///The input component for the <c>Player</c>.
    /// </summary>
    public class PlayerInputComponent : IInputComponent
    {
        public void Update(Player player, IInputController controller)
        {
            if (controller.IsMoveUp())
            {
                player.LastDirection = Direction.Up;
                player.IsIdle = false;
            }
            else if (controller.IsMoveDown())
            {
                player.LastDirection = Direction.Down;
                player.IsIdle = false;
            }
            else if (controller.IsMoveLeft())
            {
                player.LastDirection = Direction.Left;
                player.IsIdle = false;
            }
            else if (controller.IsMoveRight())
            {
                player.LastDirection = Direction.Right;
                player.IsIdle = false;
            }
            else
            {
                player.IsIdle = true;
            }
        }
    }
}

