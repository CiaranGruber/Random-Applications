using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using FormUtilities;
using GeneralUtilities;

namespace FormsBasedUnitTests
{
    [TestClass]
    public class GeneralControlUtilsTest
    {
        [TestMethod]
        public void Insert()
        {
            ControlCollection controlCollection = new ControlCollection(new Control());
            Control newControl = new Control();
            Control controlWithName = new Control
            {
                Name = "Special Control"
            };

            // Test insert while out of bounds
            try
            {
                controlCollection.Insert(5, newControl);
                Assert.Fail("Insert failed to throw an IndexOutOfRangeException");
            }
            catch (IndexOutOfRangeException) { }

            // Test insert with no other controls currently in collection
            controlCollection.Insert(0, newControl);
            Assert.AreEqual(1, controlCollection.Count, DebugUtilities.FailedAssertMessage("Insert()", 2, 1, controlCollection.Count));
            
            for (int i = 0; i < 10; ++i)
            {
                controlCollection.Add(new Control());
            }

            // Test Basic Insert
            controlCollection.Insert(4, controlWithName);
            Assert.AreEqual(controlWithName.Name, controlCollection[4], DebugUtilities.FailedAssertMessage("Insert()", 2, controlWithName.Name, controlCollection[4]));
            controlCollection.Remove(controlWithName);

            // Test Smart Insert
            controlCollection.Insert(8, controlWithName);
            Assert.AreEqual(controlWithName.Name, controlCollection[8], DebugUtilities.FailedAssertMessage("Insert()", 3, controlWithName.Name, controlCollection[8]));
            controlCollection.Remove(controlWithName);
        }
    }
}
