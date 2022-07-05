using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace Tasks.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void Test()
        {
            Rectangle player = new()
            {
                Location = new(0, 1),
                Height = 32,
                Width = 32
            };
            Rectangle block = new()
            {
                Location = new(-2, 1),
                Height = 32,
                Width = 32
            };
            List<List<Rectangle>> list = new() { new() { block } };
            World world = new()
            {
                Maps = list
            };
            world.SetPlayer(player);
            world.CurrentMap = world.Maps[0];
            Direction lastDirection = Direction.Down;
            bool isIdle = false;
            PlayerPhysicsComponent component = new();
            world.UpdateState(lastDirection, isIdle, component);
            Assert.IsTrue(world.GetPlayer().Location.Equals(new(0, 3)));

            world.UpdateState(lastDirection, isIdle, component);
            Assert.IsTrue(world.GetPlayer().Location.Equals(new(0, 5)));

            lastDirection = Direction.Left;
            world.UpdateState(lastDirection, isIdle, component);
            Assert.IsTrue(world.GetPlayer().Location.X == 0);

            lastDirection = Direction.Down;
            world.UpdateState(lastDirection, isIdle, component);
            Assert.IsTrue(world.GetPlayer().Location.Y == 7);
        }
    }
}