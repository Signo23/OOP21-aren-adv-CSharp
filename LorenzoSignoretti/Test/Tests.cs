using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tasks.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void EventsTest()
        {
            GameObject key = new(new Point2D(), true, BaseObjectEnum.Key);
            GameObject potion = new(new Point2D(), true, BaseObjectEnum.Potion);
            IBaseEvent chestEvent = new InteractWithPlayerEvent(potion, "Ecco la pozione");
            IBaseEvent boxEvent = new InteractWithPlayerEvent(key, potion, "Ecco la chiave" , "Prima la pozione");
            Block chestBlock = new(new Point2D(), true, BaseObjectEnum.Chest, chestEvent);
            Block boxBlock = new(new Point2D(), true, BaseObjectEnum.Box, boxEvent);
            GameMap map = new();
            Player player = new(new Point2D());
            map.AddBlocks(new List<Block> { chestBlock, boxBlock });

            foreach ( Block b in map.Blocks)
            {
                b.Event.Launch(player);
            }
            Assert.IsTrue(player.BackPack.Contains(key));
            Assert.IsTrue(player.BackPack.Contains(potion));

        }


    }

}