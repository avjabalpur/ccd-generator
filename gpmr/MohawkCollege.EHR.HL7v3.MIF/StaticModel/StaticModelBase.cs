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
using System.Xml;

namespace MohawkCollege.EHR.HL7v3.MIF.MIF10.StaticModel
{
    /// <summary>
    /// Basic content for defining static models and subject areas
    /// </summary>
    /// <remarks>
    /// Graphical representation data has been removed to ease processing
    /// </remarks>
    [XmlType(TypeName = "StaticModelBase", Namespace = "urn:hl7-org:v3/mif")]
    public abstract class StaticModelBase : SubSystem
    {

        private StaticModelRepresentationKind representationKind;
        private bool isSerializable;
        private bool isAbstract;
        private StaticModelAnnotation annotations;
        private List<StaticModelDerivation> derivationSupplier;
        private List<StaticModelDerivationSource> derivationClient;
        private PackageRef importedDatatypeModelPackage;
        private PackageRef importedCommonModelElementPackage;
        private PackageRef importedStubPackage;
        private List<SubjectAreaPackage> ownedSubjectAreaPackage;

        /// <summary>
        /// Identifies a sub-package owned by the current static package. All class' within the sub-packages are
        /// always imported into their parent static package. This means that the names of all classes within a static
        /// package must be unique. 
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement(ElementName = "ownedSubjectAreaPackage")]
        public List<SubjectAreaPackage> OwnedSubjectAreaPackage
        {
            get { return ownedSubjectAreaPackage; }
            set { ownedSubjectAreaPackage = value; }
        }
	

        /// <summary>
        /// The stub set that is used by this model
        /// </summary>
        [XmlElement(ElementName = "importedStubPackage")]
        public PackageRef ImportedStubPackage
        {
            get { return importedStubPackage; }
            set { importedStubPackage = value; }
        }
	
        /// <summary>
        /// The CMET model that is used by this model
        /// </summary>
        [XmlElement(ElementName = "importedCommonModelElementPackage")]
        public PackageRef ImportedCommonModelElementPackage
        {
            get { return importedCommonModelElementPackage; }
            set { importedCommonModelElementPackage = value; }
        }

        /// <summary>
        /// The datatype model that is used by this model
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Datatype"), XmlElement(ElementName = "importedDatatypeModelPackage")]
        public PackageRef ImportedDatatypeModelPackage
        {
            get { return importedDatatypeModelPackage; }
            set { importedDatatypeModelPackage = value; }
        }
	
        /// <summary>
        /// Identifies static models derived from the current model
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement(ElementName = "derivationClient")]
        public List<StaticModelDerivationSource> DerivationClient
        {
            get { return derivationClient; }
            set { derivationClient = value; }
        }
	
        /// <summary>
        /// Identifies static model from which the current model is derived
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement(ElementName = "derivationSupplier")]
        public List<StaticModelDerivation> DerivationSupplier
        {
            get { return derivationSupplier; }
            set { derivationSupplier = value; }
        }
	
        /// <summary>
        /// Descriptive information about the containing element
        /// </summary>
        [XmlElement("annotations")]
        public StaticModelAnnotation Annotations
        {
            get { return annotations; }
            set { annotations = value; }
        }

        /// <summary>
        /// Indicates that the specified datatype can not be instanced
        /// </summary>
        [XmlAttribute("isAbstract")]
        public bool IsAbstract
        {
            get { return isAbstract; }
            set { isAbstract = value; }
        }
	

        /// <summary>
        /// Indicates that this model can be represented in serialized form
        /// </summary>
        [XmlAttribute("isSerializable")]
        public bool IsSerializable
        {
            get { return isSerializable; }
            set { isSerializable = value; }
        }
	
        /// <summary>
        /// Identifies whether the model is represented in its flat or serializable form
        /// </summary>
        [XmlAttribute("representationKind")]
        public StaticModelRepresentationKind RepresentationKind
        {
            get { return representationKind; }
            set { representationKind = value; }
        }
	
    }
}