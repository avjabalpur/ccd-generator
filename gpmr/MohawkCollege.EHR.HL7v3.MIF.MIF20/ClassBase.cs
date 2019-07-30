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
 * User: Justin Fyfe
 * Date: 01-09-2009
 **/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MohawkCollege.EHR.HL7v3.MIF.MIF20
{
    /// <summary>
    /// Corresponds to a class
    /// </summary>
    [XmlType(TypeName = "ClassBase", Namespace = "urn:hl7-org:v3/mif2")]
    public class ClassBase : ClassRoot
    {

        private string name;
        private Annotation annotations;
        private StateMachine behavior;
        private List<CommitteeReference> stewardCommittee;
        private List<CommitteeReference> interestedCommittee;
        private List<ClassAttribute> attribute;
        private SubSystem container;

        /// <summary>
        /// Container package
        /// </summary>
        [XmlIgnore()]
        public SubSystem Container
        {
            get { return container; }
            set { container = value; }
        }
	
        /// <summary>
        /// An independently modifiable or static characteristic of a class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement(ElementName = "attribute")]
        public List<ClassAttribute> Attribute
        {
            get { return attribute; }
            set { attribute = value; }
        }

        /// <summary>
        /// Identifies the non-predominant groups with which this class is associated
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement(ElementName = "interestedCommittee")]
        public List<CommitteeReference> InterestedCommittee
        {
            get { return interestedCommittee; }
            set { interestedCommittee = value; }
        }
	
        /// <summary>
        /// Identifies the group with which this class is predominantly associated with
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement(ElementName = "stewardCommittee")]
        public List<CommitteeReference> StewardCommittee
        {
            get { return stewardCommittee; }
            set { stewardCommittee = value; }
        }
	
        /// <summary>
        /// Defines the set of available states and transistions available for the class
        /// </summary>
        [XmlElement(ElementName = "behavior")]
        public StateMachine Behavior
        {
            get { return behavior; }
            set { behavior = value; }
        }
	
        /// <summary>
        /// Descriptive information about the element
        /// </summary>
        [XmlElement(ElementName = "annotations")]
        public Annotation Annotations
        {
            get { return annotations; }
            set { annotations = value; }
        }

	    /// <summary>
	    /// The unique formal name for the class within the model
	    /// </summary>
        [XmlAttribute("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
	
    }
}