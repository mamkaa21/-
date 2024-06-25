using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty.Tests
{
    public class CommandsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        private void CommandCreateIsNotNull() 
        {
            string commandManager = new string;
            Type type = commandManager.GetType();
            var command = type.GetProperty("Create");
            Assert.IsNotNull(command);
            Assert.That(command.PropertyType, Is.EqualTo(typeof(string)));
        }
    }
}
