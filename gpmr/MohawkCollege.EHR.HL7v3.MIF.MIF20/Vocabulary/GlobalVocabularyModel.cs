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

namespace MohawkCollege.EHR.HL7v3.MIF.MIF20.Vocabulary
{
    /// <summary>
    /// Extends vocabulary model for use as a stand-alone XML document
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance"), XmlRoot(ElementName = "vocabularyModel", Namespace = "urn:hl7-org:v3/mif2")]
    [XmlType(TypeName = "GlobalVocabularyModel", Namespace = "urn:hl7-org:v3/mif2")]
    public class GlobalVocabularyModel : VocabularyModel
    {
        /// <summary>
        /// Identifies what schema version this content complies with
        /// </summary>
        [XmlAttribute("schemaVersion")]
        public string SchemaVersion { get; set; }
    }
}