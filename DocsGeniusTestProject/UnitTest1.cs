using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocsGenius.Models;
using System.Linq;
using System.Collections.Generic;

namespace DocsGeniusTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //adding register only with the required fields (Id auto increment)
        [TestMethod]
        public void CanAddDocTemplateWithLinkAndName()
        {
            List<DocsTemplate> templates = new List<DocsTemplate>();
            templates.Add(new DocsTemplate { Link = "www.hello.com", Name = "doc1" });
        }

        //adding register with required fields and description
        [TestMethod]
        public void CanAddDocTemplateWithLinkNameAndDescription()
        {
            List<DocsTemplate> templates = new List<DocsTemplate>();
            templates.Add(new DocsTemplate { Link = "www.hello.com", Name = "doc1", Description="it is a test"  });
        }

        [TestMethod]
        public void CanAddDocTemplateWithLinkNameDescriptionAndID()
        {
            List<DocsTemplate> templates = new List<DocsTemplate>();
            templates.Add(new DocsTemplate {Id=11, Link = "www.hello.com", Name = "doc1", Description = "it is a test" });
        }
    }
}
