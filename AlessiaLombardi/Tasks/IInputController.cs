namespace AlessiaLombardi.Tasks 
{
    ///<summary>
    ///The interface for the input's controller
    ///</summary>
    public interface InputController
    {

        bool IsMoveUp();
        bool IsMoveDown();
        bool IsMoveLeft();
        bool IsMoveRight();
        bool IsInteract();
        bool IsOnClose();
    }
}
