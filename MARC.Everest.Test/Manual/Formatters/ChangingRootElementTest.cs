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
using MARC.Everest.Xml;
using System.Xml;

using MARC.Everest.Connectors;
using MARC.Everest.Formatters.XML.ITS1;
using MARC.Everest.Formatters.XML.Datatypes.R1;
using MARC.Everest.RMIM.UV.NE2008.Interactions;
using MARC.Everest.RMIM.UV.NE2008.Vocabulary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MARC.Everest.DataTypes;
using MARC.Everest.RMIM.CA.R020403.REPC_MT420003CA;     // used for the Subject()
using MARC.Everest.RMIM.UV.NE2008.COCT_MT050000UV01;    // used to create new Patient
using MARC.Everest.RMIM.CA.R020403.REPC_MT500005CA;
using MARC.Everest.RMIM.CA.R020403.PRPA_MT101106CA;     // used to create new Person

namespace MARC.Everest.Test.Manual.Formatters
{
    /// <summary>
    /// Summary description for ChangingRootElement
    /// </summary>
    [TestClass]
    public class ChangingRootElementTest
    {
        public ChangingRootElementTest()
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
        /// Example 75
        /// Changing the root element of serialization.
        /// This manual example is theoretical.
        /// </summary>
        [TestMethod]
        public void XmlStateWriterTest01()
        {
            /*
            XmlWriter xw = null;
            
            try
            {
                // Setup the formatter
                IXmlStructureFormatter structureFormatter = new XmlIts1Formatter()
                {
                    ValidateConformance = false
                };
                structureFormatter.GraphAides.Add(new DatatypeFormatter());

                // Initialize the XmlWriter & State writer
                xw = XmlWriter.Create("mydata.xml", new XmlWriterSettings() { Indent = true });
                XmlStateWriter xsw = new XmlStateWriter(xw);

                // Write something at the start
                xsw.WriteStartElement("patientDataSnippet", "urn:hl7-org:v3");

                // Create a simple instance
                Patient instance = new Patient(
                    SET<II>.CreateSET(new II("2.3.4.5.3.4", "230495")),
                    RoleStatus.Active,
                    null,
                    new MARC.Everest.RMIM.UV.NE2008.COCT_MT150003UV03.Organization()
                        { NullFlavor = NullFlavor.NoInformation },
                    new Subject() { NullFlavor = NullFlavor.NotApplicable }
                    );

                // Construct the patient
                instance.SetPatientEntityChoiceSubject(new Person(
                    BAG<PN>.CreateBAG(new PN(EntityNameUse.Legal,
                        new ENXP[] {
                            new ENXP("John Smith")
                        }
                    ))
                    ) { AdministrativeGenderCode = AdministrativeGender.Male }
                );

                // Format
                var result = structureFormatter.Graph(xsw, instance);

                // Flush state writer
                xsw.Flush();
            }
            finally
            {
                if (xw != null)
                    xw.Close();
            }
            */
        }
    }
}
