﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ErrorProneWebsite.Models;

namespace ErrorProneWebsite.Tests
{
    [TestClass]
    public class FileManagerTest
    {
        private const string TEST_FILE_PATH = @"C:\Users\Jai\Desktop\CTEC2902GitLabs\Week17-ErrorHandlingWebsite\ErrorProneWebsite.Tests\TestContent\Content.txt";
        
        [TestMethod]
        public void TheFileManagerCanReadAFile()
        {
            FileManager fileManager = new FileManager(TEST_FILE_PATH);

            Assert.AreEqual("Here is some test content.", fileManager.GetContent());


        }
    }
}
