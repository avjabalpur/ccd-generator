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
 * Date: 10-6-2013
 */
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MARC.Everest.DataTypes;
using MARC.Everest.DataTypes.Interfaces;
using MARC.Everest.Connectors;
using MARC.Everest.RMIM.UV.NE2008.Interactions;
using MARC.Everest.RMIM.UV.NE2008.Vocabulary;
using MARC.Everest.Formatters.XML.ITS1;
using MARC.Everest.Formatters.XML.Datatypes.R1;
using System.Reflection;
using MARC.Everest.RMIM.CA.R020402.POLB_MT004100CA;
using MARC.Everest.RMIM.CA.R020402.Interactions;

namespace MARC.Everest.Test.Manual.Formatters
{
    /// <summary>
    /// Summary description for ParseFromStream01
    /// </summary>
    [TestClass]
    public class ParseFromStreamTest
    {
        public ParseFromStreamTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static string[] GetResourceList()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceNames();
        }

        public static Stream GetResourceStream(string scriptname)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream(scriptname);
        }

        public static string FindResource(string neededResource)
        {
            foreach (string name in ParseFromStreamTest.GetResourceList())
            {
                if (name.ToString().Contains(neededResource))
                {
                    neededResource = name;
                }
            }
            return neededResource;
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
        /// Parsing from a Stream.
        /// This test will grab an instance from an assembly resource
        /// file, parse the file, and verifiy if the result contains a
        /// valid instance of MCCI_IN000000UV01.
        /// 
        /// Xml Instance Parsed     :   MCCI_IN000000UV01
        /// Xml Instance Expected   :   MCCI_IN000000UV01
        /// Assertion should return TRUE.
        /// </summary>
        [TestMethod]
        public void StreamParseTest01()
        {
            // Find the resource to be parsed.
            string neededResource = FindResource("MCCI_IN000000UV01.xml");

            // Load the assembly into the current AppDomain
            var asm = Assembly.Load(new AssemblyName("MARC.Everest.RMIM.UV.NE2008, Version=1.0.4366.42027, Culture=neutral"));

            // Initialize stream that will read the needed resource file.
            Stream s = null;

            try
            {
                // Set the stream by reading from a file
                // whose datatype is MCCI_IN000000UV01
                s = GetResourceStream(neededResource);
                if (s == null)
                    Console.WriteLine("Invalid input stream.");
                
                // Setup the formatter
                var structureFormatter = new XmlIts1Formatter()
                {
                    ValidateConformance = false
                };

                // Add graphing aides
                structureFormatter.GraphAides.Add(new DatatypeFormatter());

                // Parse Resource Stream
                var result = structureFormatter.Parse(s, asm);

                // Output the type of instance that was parsed
                Console.WriteLine("This file contains a '{0}' instance.", result.Structure.GetType().Name);

                Assert.IsTrue(result.Structure.GetType() == typeof(MCCI_IN000000UV01));
                Assert.IsTrue(result.Structure.GetType().Name == "MCCI_IN000000UV01");
            }
            finally
            {
                if (s != null)
                    s.Close();
            }
        }



        /// <summary>
        /// Parsing from a Stream.
        /// This test will grab an instance from an assembly resource
        /// file, parse the file, and verifiy if the result contains a
        /// valid instance of MCCI_IN000000UV01.
        /// 
        /// Xml Instance Parsed     :   PRPA_IN101103CA
        /// Xml Instance Expected   :   MCCI_IN000000UV01
        /// Assertion should return FALSE.
        /// </summary>
        [TestMethod]
        public void StreamParseTest02()
        {
            // Find the resource to be parsed.
            string neededResource = FindResource("PRPA_IN101103CA.xml");


            // Initialize stream that will read the needed resource file.
            Stream s = null;

            try
            {
                // Set the stream by reading from a file
                // whose datatype is MCCI_IN000000UV01
                s = GetResourceStream(neededResource);
                if (s == null)
                    Console.WriteLine("Invalid input stream.");

                // Setup the formatter
                ICodeDomStructureFormatter structureFormatter = new XmlIts1Formatter()
                {
                    ValidateConformance = false
                };

                // Add graphing aides
                structureFormatter.GraphAides.Add(new DatatypeFormatter());

                // Parse Resource Stream
                var result = structureFormatter.Parse(s, typeof(PRPA_IN101103CA).Assembly);

                // Output the type of instance that was parsed
                Console.WriteLine("This file contains a '{0}' instance.", result.Structure.GetType().Name);

                // Main assertion
                Assert.IsFalse(result.Structure.GetType() == typeof(MCCI_IN000000UV01));

                // Correct parsing verification.
                Assert.IsTrue(result.Structure.GetType() == typeof(PRPA_IN101103CA));
            }
            finally
            {
                if (s != null)
                    s.Close();
            }
        }
    }
}
