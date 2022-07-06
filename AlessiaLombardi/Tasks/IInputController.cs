namespace Tasks 
{
    ///<summary>
    ///The interface for the input's controller
    ///</summary>
    public interface IInputController
    {
        bool IsMoveUp();
        bool IsMoveDown();
        bool IsMoveLeft();
        bool IsMoveRight();
        bool IsInteract();
        bool IsOnClose();
    }
}
