using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void EventsTest()
        {
            GameObject _key = new(new Point2D(), true, BaseObjectEnum.Key);
            GameObject _potion = new(new Point2D(), true, BaseObjectEnum.Potion);
            List<GameObject> _gameObjects = new List<GameObject> { _potion, _key };
            IBaseEvent _chestEvent = new InteractWithPlayerEvent(@_potion, "Ecco la pozione");
            IBaseEvent _boxEvent = new InteractWithPlayerEvent(@_key, @_potion, "Ecco la chiave" , "Prima la pozione");
            Block _chestBlock = new(new Point2D(), true, BaseObjectEnum.Chest, _chestEvent);
            Block _boxBlock = new(new Point2D(), true, BaseObjectEnum.Box, _boxEvent);
            GameMap _map = new();
            Player _player = new(new Point2D());
            _map.AddBlocks(new List<Block> { _chestBlock, _boxBlock });

            foreach ( Block b in _map.Blocks)
            {
                b.Event.Launch(@_player);
            }
            Assert.IsTrue(_player.BackPack.Contains(_key));
            Assert.IsTrue(_player.BackPack.Contains(_potion));

        }


    }

}