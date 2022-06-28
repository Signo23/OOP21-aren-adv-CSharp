using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class InteractWithPlayerEvent : IBaseEvent
    {
        private bool _isAlreadyLunch;

        public GameObject Object { get; private set; }
        public GameObject? Requirement { get; private set; }
        public string Dialog { get; private set; }
        public string? AlternativeDialog { get; private set; }

        public InteractWithPlayerEvent(GameObject @object, string dialog)
        {
            Object = @object;
            Dialog = dialog;
            _isAlreadyLunch = false;
        }
        public InteractWithPlayerEvent(GameObject @object, GameObject? requirement, string dialog, string? alternativeDialog) : this(@object, dialog)
        {
            Requirement = requirement;
            AlternativeDialog = alternativeDialog;
        }

        public void Launch(Player @player)
        {
            if (Requirement != null)
            {
                if (player.BackPack.Contains(Requirement))
                {
                    LaunchMainEvent(@player);
                } 
                else
                {
                    Console.WriteLine(AlternativeDialog);
                }
            }
            else
            {
                LaunchMainEvent(@player);
            }
        }
        private void LaunchMainEvent(Player @player)
        {
            Console.WriteLine(Dialog);
            @player.BackPack.Add(Object);
            _isAlreadyLunch = true;
        }

        public bool isAlreadyLunch()
        {
            return _isAlreadyLunch;
        }
    }
}
