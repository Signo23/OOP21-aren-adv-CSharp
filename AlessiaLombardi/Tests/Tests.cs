using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tasks.Test
{
    [TestClass()]
    public class Input
    {
        [TestMethod()]
        public void TestGiveToPlayerInput()
        {
            Player player = new Player(new PlayerInputComponent());
            KeyboardInputController controller = new KeyboardInputController();

            controller.NotifyMoveUp();
            player.UpdateInput(controller);
            Assert.AreEqual(player.LastDirection, Direction.Up);
            Assert.IsFalse(player.IsIdle);
            controller.NotifyNoMoreMoveUp();

            controller.NotifyMoveDown();
            player.UpdateInput(controller);
            Assert.AreEqual(player.LastDirection, Direction.Down);
            Assert.IsFalse(player.IsIdle);
            controller.NotifyNoMoreMoveDown();

            controller.NotifyMoveLeft();
            player.UpdateInput(controller);
            Assert.AreEqual(player.LastDirection, Direction.Left);
            Assert.IsFalse(player.IsIdle);
            controller.NotifyNoMoreMoveLeft();

            controller.NotifyMoveRight();
            player.UpdateInput(controller);
            Assert.AreEqual(player.LastDirection, Direction.Right);
            Assert.IsFalse(player.IsIdle);
            controller.NotifyNoMoreMoveRight();

            player.UpdateInput(controller);
            Assert.IsTrue(player.IsIdle);
        }
    }
}


