using System;
using NUnit.Framework;
using UnityEngine;

namespace Scriban.Tests.Editor
{
    class EditorTests
    {
        [Test]
        public void PluginTest()
        {
            var template = Template.Parse(null);
            var codegen = template.Render();
            Assert.AreEqual(codegen, string.Empty);
        }
    }
}
