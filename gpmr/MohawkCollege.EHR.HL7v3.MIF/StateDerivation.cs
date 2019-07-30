/* 
 * Copyright 2008/2009 Mohawk College of Applied Arts and Technology
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
 * User: Justin Fyfe
 * Date: 01-09-2009
 **/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MohawkCollege.EHR.HL7v3.MIF.MIF10
{
    /// <summary>
    /// A derivation stereotype to a state
    /// </summary>
    [XmlType(TypeName = "StateDerivation", Namespace = "urn:hl7-org:v3/mif")]
    public class StateDerivation : ClassDerivation
    {
        private string stateName;

        /// <summary>
        /// The name of the corresponding state in the parent model
        /// </summary>
        [XmlAttribute("stateName")]
        public string StateName
        {
            get { return stateName; }
            set { stateName = value; }
        }
	
    }
}