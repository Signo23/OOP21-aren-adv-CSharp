namespace AlessiaLombardi.Tasks
{
    ///<summary>
    ///The input controller for the keyboard.
    ///Implements <c>InputController</c>
    ///</summary>
    public class KeyboardInputController : IInputController
    {
        private bool isMoveUp;
        private bool isMoveDown;
        private bool isMoveLeft;
        private bool isMoveRight;
        private bool isInteract;
        private bool isOnClose;

        ///<summary>
        ///Return isMoveUp.
        ///</summary>
        ///<return>true if it's moving up, false otherwise</return>
        public bool IsMoveUp()
        {
            return this.isMoveUp;
        }

        ///<summary>
        ///Return isMoveDown.
        ///</summary>
        ///<return>true if it's moving down, false otherwise</return>
        public bool IsMoveDown()
        {
            return this.isMoveDown;
        }

        ///<summary>
        ///Return isMoveLeft.
        ///</summary>
        ///<return>true if it's moving left, false otherwise</return>
        public bool IsMoveLeft()
        {
            return this.isMoveLeft;
        }

        ///<summary>
        ///Return isMoveRight.
        ///</summary>
        ///<return>true if it's moving right, false otherwise</return>
        public bool IsMoveRight()
        {
            return this.isMoveRight;
        }

        ///<summary>
        ///Return isInteract.
        ///</summary>
        ///<return>true if it's interacting, false otherwise</return>
        public bool IsInteract()
        {
            return this.isInteract;
        }

        ///<summary>
        ///Return isOnClose.
        ///</summary>
        ///<return>true if it's closing, false otherwise</return>
        public bool IsOnClose()
        {
            return this.isOnClose;
        }

        ///<summary>
        ///Set isMoveUp to true.
        ///</summary>
        public void NotifyMoveUp()
        {
            this.isMoveUp = true;
        }

        ///<summary>
        ///Set isMoveUp to false.
        ///</summary>
        public void NotifyNoMoreMoveUp()
        {
            this.isMoveUp = false;
        }

        ///<summary>
        ///Set isMoveDown to true.
        ///</summary>
        public void NotifyMoveDown()
        {
            this.isMoveDown = true;
        }

        ///<summary>
        ///Set isMoveDown to false.
        ///</summary>
        public void NotifyNoMoreMoveDown()
        {
            this.isMoveDown = false;
        }

        ///<summary>
        ///Set isMoveLeft to true.
        ///</summary>
        public void NotifyMoveLeft()
        {
            this.isMoveLeft = true;
        }

        ///<summary>
        ///Set isMoveLeft to false.
        ///</summary>
        public void NotifyNoMoreMoveLeft()
        {
            this.isMoveLeft = false;
        }

        ///<summary>
        ///Set isMoveRight to true.
        ///</summary>
        public void NotifyMoveRight()
        {
            this.isMoveRight = true;
        }

        ///<summary>
        ///Set isMoveRight to false.
        ///</summary>
        public void NotifyNoMoreMoveRight()
        {
            this.isMoveRight = false;
        }

        ///<summary>
        ///Set isInteract to true.
        ///</summary>
        public void NotifyInteract()
        {
            this.isInteract = true;
        }

        ///<summary>
        ///Set isInteract to false.
        ///</summary>
        public void NotifyNoMoreInteract()
        {
            this.isInteract = false;
        }

        ///<summary>
        ///Set isOnClose to true.
        ///</summary>
        public void NotifyOnClose()
        {
            this.isOnClose = true;
        }

        ///<summary>
        ///Set isOnClose to false.
        ///</summary>
        public void NotifyNoMoreOnClose()
        {
            this.isOnClose = false;
        }
    }
}
