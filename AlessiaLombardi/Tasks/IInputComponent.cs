namespace Tasks
{
    /// <summary>
    /// The input component interface to update the input.
    /// </summary>
    public interface IInputComponent
    {
        ///<summary>
        ///Update the <c>BaseEntity</c> based on the <c>InputController</c>.
        ///</summary>
        ///<param name="player">the <c>Player</c> to update</param>
        ///<param name="controller">the <c>InputController</c> to use for update entity</param>
        void Update(Player player, IInputController controller);
    }

}
