using LorenzoSignoretti.BaseEntity;
namespace AlessiaLombardi.Task
{
    /// <summary>
    /// The input component interface to update the input.
    /// </summary>
    public interface InputComponent
    {
        ///<summary>
        ///Update the <c>BaseEntity</c> based on the <c>InputController</c>.
        ///</summary>
        ///<param name="entity">the <c>BaseEntity</c> to update</param>
        ///<param name="controller">the <c>InputController</c> to use for update entity</param>
        void Update(BaseEntity entity, InputController controller);
    }

}
