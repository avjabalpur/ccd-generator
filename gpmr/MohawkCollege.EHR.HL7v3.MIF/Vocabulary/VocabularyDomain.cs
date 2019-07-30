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

namespace MohawkCollege.EHR.HL7v3.MIF.MIF10.Vocabulary
{
    /// <summary>
    /// Created from schema auto-generated off of instance
    /// </summary>
    [XmlRoot(ElementName = "vocabularyDomain", Namespace = "urn:hl7-org:v3/mif")]
    [XmlType(TypeName = "VocabularyDomain", Namespace = "urn:hl7-org:v3/mif")]
    public class VocabularyDomain : VocabularyTableContents
    {
        private string mnemonic;

        /// <summary>
        /// Code mnemonic
        /// </summary>
        [XmlAttribute("mnemonic")]
        public string Mnemonic
        {
            get { return mnemonic; }
            set { mnemonic = value; }
        }

        /// <summary>
        /// Get a property by name
        /// </summary>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Property"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        public string GetProperty(String PropertyName)
        {
            foreach (Object c in Contents)
                if (c is VocabularyProperty && (c as VocabularyProperty).Name == PropertyName)
                    return (c as VocabularyProperty).Value;

            return null;
        }
    }
}