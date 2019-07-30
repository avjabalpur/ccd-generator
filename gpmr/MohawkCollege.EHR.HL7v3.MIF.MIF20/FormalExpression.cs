/* 
 * Copyright 2008-2013 Mohawk College of Applied Arts and Technology
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
 * User: $user$
 * Date: 01-09-2009
 **/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace MohawkCollege.EHR.HL7v3.MIF.MIF20
{
    /// <summary>
    /// A constraint expressed in a particular language
    /// </summary>
    [XmlType(TypeName = "FormalExpression", Namespace = "urn:hl7-org:v3/mif2")]
    public class FormalExpression
    {
        /// <summary>
        /// A constraint expressed in a particular language
        /// </summary>
        [XmlAttribute("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// The body of the expression
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), XmlAnyElement]
        public XmlElement[] Body { get; set; }
    }
}