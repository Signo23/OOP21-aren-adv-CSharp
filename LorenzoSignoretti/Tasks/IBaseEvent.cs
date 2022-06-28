namespace Tasks
{
    /// <summary>
    /// Interface for create events that interact with the game.
    /// </summary>
    public interface IBaseEvent
    {
        /// <summary>
        /// Launch the event.
        /// </summary>
        /// <param name="player"> <see cref="Player"/> to interact with</param>
        void Launch(Player player);//Used Player instaed of GameState

        /// <summary>
        /// Check if the event was already launched.
        /// </summary>
        /// <returns>true if was launched, false otherwise</returns>
        bool isAlreadyLunch();
    }
}
