using System.Drawing;
namespace Tasks
{
    /// <summary>
    /// Model for the player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The input for the player</c>
        /// </summary>
        private readonly IInputComponent inputComponent;

        /// <summary>
        /// Represent if player is idle.
        /// </summary>
        public bool IsIdle { get; set; }

        /// <summary>
        /// Player's last direction
        /// </summary>
        public Direction LastDirection { get; set; }

        /// <summary>
        /// Create a player.
        /// </summary>
        /// <param name="input">the <c>PlayerInputComponent</c> for the player</param>
        public Player(PlayerInputComponent input)
        {
            IsIdle = true;
            LastDirection = Direction.Down;
            inputComponent = input;
        }

        /// <summary>
        /// Update the player's <c>InputComponent</c>
        /// </summary>
        /// <param name="i">the <c>InputController</c> for update the input</param>
        public void UpdateInput(IInputController i) => inputComponent.Update(this, i);
    }
}
