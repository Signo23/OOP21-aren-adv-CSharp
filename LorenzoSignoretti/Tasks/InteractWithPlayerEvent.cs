namespace Tasks
{
    public class InteractWithPlayerEvent : IBaseEvent
    {
        private bool _isAlreadyLunch;
        private readonly GameObject _object;
        private readonly GameObject? _requirement;
        private readonly string _dialog;
        private readonly string? _alternativeDialog;

        /// <summary>
        /// Constructor for InteractWithPlayerEvent.
        /// </summary>
        /// <param name="object">the <see cref="GameObject"/> to give to <see cref="Player"/></param>
        /// <param name="dialog">the message to display</param>
        public InteractWithPlayerEvent(GameObject @object, string dialog)
        {
            _object = @object;
            _dialog = dialog;
            _isAlreadyLunch = false;
        }

        /// <summary>
        /// Constructor for InteractWithPlayerEvent with requirement.
        /// </summary>
        /// <param name="object">the <see cref="GameObject"/> to give to <see cref="Player"/></param>
        /// <param name="requirement">the <see cref="GameObject"/> required to launch the main event</param>
        /// <param name="dialog">the message to display </param>
        /// <param name="alternativeDialog">the message to display if the requirement is not respected</param>
        public InteractWithPlayerEvent(GameObject @object, GameObject? requirement, string dialog, string? alternativeDialog) : this(@object, dialog)
        {
            _requirement = requirement;
            _alternativeDialog = alternativeDialog;
        }

        public void Launch(Player player)
        {
            if (_requirement != null)
            {
                if (player.BackPack.Contains(_requirement))
                {
                    LaunchMainEvent(player);
                } 
                else
                {
                    Console.WriteLine(_alternativeDialog);
                }
            }
            else
            {
                LaunchMainEvent(player);
            }
        }
        private void LaunchMainEvent(Player player)
        {
            Console.WriteLine(_dialog);
            player.BackPack.Add(_object);
            _isAlreadyLunch = true;
        }

        public bool isAlreadyLunch()
        {
            return _isAlreadyLunch;
        }
    }
}
