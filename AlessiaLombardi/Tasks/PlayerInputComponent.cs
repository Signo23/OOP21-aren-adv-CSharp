namespace AlessiaLombardi.Tasks
{
    using LorenzoSignoretti.Tasks.BaseEntity;
    using LorenzoSignoretti.Tasks.Player;
    using LorenzoSignoretti.Tasks.Direction;
    ///<summary>
    ///The input component for the <c>Player</c>.
    /// </summary>
    public class PlayerInputComponent : IInputComponent
    {
        override
        public void Update(BaseEntity entity, InputController controller)
        {
            if (controller.IsMoveUp())
            {
                ((Player)entity).SetLastDirection(Direction.UP);
                ((Player)entity).SetIdle(false);
            }
            else if (controller.IsMoveDown())
            {
                ((Player)entity).SetLastDirection(Direction.DOWN);
                ((Player)entity).SetIdle(false);
            }
            else if (controller.IsMoveLeft())
            {
                ((Player)entity).SetLastDirection(Direction.LEFT);
                ((Player)entity).SetIdle(false);
            }
            else if (controller.IsMoveRight())
            {
                ((Player)entity).SetLastDirection(Direction.RIGHT);
                ((Player)entity).SetIdle(false);
            }
            else
            {
                ((Player)entity).SetIdle(true);
            }
        }
    }
}

