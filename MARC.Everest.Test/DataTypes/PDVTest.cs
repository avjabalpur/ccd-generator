﻿/**
 * Copyright 2008-2014 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: fyfej
 * Date: 3-6-2013
 */
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MARC.Everest.DataTypes;

namespace MARC.Everest.Test.DataTypes
{
    /// <summary>
    /// Summary description for PDVTest
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDV"), TestClass]
    public class PDVTest
    {
        public PDVTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// Ensure that validation succeeds (return TRUE)
        /// When the following values are being populated:
        ///     Value       : Initial value
        /// And, the following variables are nullified:
        ///     NullFlavor
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDV"), TestMethod]
        public void PDVValueTest()
        {
            PDV<Nullable<Int32>> a = new INT();
            a.Value = 3;
            a.NullFlavor = null;
            Assert.IsTrue(a.Validate());            
        }

        /// <summary>
        /// Ensure that validation fails (return FALSE)
        /// When the following values are being populated:
        ///     Value       : Initial value
        ///     NullFlavor
        /// And, there are no variables being nullified:
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDV"), TestMethod]
        public void PDVValueNullFlavorTest()
        {
            PDV<Nullable<Int32>> a = new INT();
            a.Value = 3;
            a.NullFlavor = NullFlavor.NotAsked;
            Assert.IsFalse(a.Validate());
        }

        /// <summary>
        /// Ensure that validation succeeds (return TRUE)
        /// When the following values are being populated:
        ///     NullFlavor
        /// And, the following variables are nullified:
        ///     Value       : Initial value
        /// </summary>        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDV"), TestMethod]
        public void PDVNullFlavorTest()
        {
            PDV<Nullable<Int32>> a = new INT();
            a.Value = null;
            a.NullFlavor = NullFlavor.NotAsked;
            Assert.IsTrue(a.Validate());
        }

        /// <summary>
        /// Ensure that validation succeeds (return TRUE)
        /// When there are no values being populated:
        /// And, the following variables are nullified:
        ///     Value       : Initial value
        ///     NullFlavor
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDV"), TestMethod]
        public void PDVNullTest()
        {
            PDV<Nullable<Int32>> a = new INT();
            a.Value = null;
            a.NullFlavor = null;
            Assert.IsFalse(a.Validate());
        }
    }
}
