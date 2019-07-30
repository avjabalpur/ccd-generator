﻿/* 
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
 * User: Jaspinder Singh
 **/


using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using MARC.Everest.DataTypes;
using MARC.Everest.Connectors;
using System.Reflection;



namespace MARC.Everest.Formatters.XML.Datatypes.R1.Formatters
{
    /// <summary>
    /// Trivial Name Formatter.
    /// </summary>
    public class TNFormatter : ANYFormatter, IDatatypeFormatter
    {

       
        #region IDatatypeFormatter Members


        /// <summary>
        /// Graphs the object <paramref name="o"/> onto the stream.
        /// </summary>
        /// <param name="s">The XmlWriter stream to write to.</param>
        /// <param name="o">The object to graph.</param>
        public override void Graph(System.Xml.XmlWriter s, object o, DatatypeFormatterGraphResult result)
        {
            TN tn = (TN)o;
            base.Graph(s, o, result);

            if (tn.Part.Count > 0 && tn.NullFlavor == null)
                s.WriteString(tn.Part[0].Value);
            if (tn.Part.Count > 1)
                result.AddResultDetail(new InsufficientRepetitionsResultDetail(ResultDetailType.Warning,
                    "TN is only permitted to have one part",
                    s.ToString()));
        }

        /// <summary>
        /// Parse the TN from the XmlReader <paramref name="s"/>.
        /// </summary>
        /// <param name="s">XmlReader stream to parse from.</param>
        /// <returns>Parsed TN.</returns>
        public override object Parse(System.Xml.XmlReader s, DatatypeFormatterParseResult result)
        {
            TN tn = base.Parse<TN>(s, result);

            // Parse the mixed content and add it to the list.
            if (!s.IsEmptyElement)
            {
                string oldName = s.LocalName;
                ENXP tnPart = new ENXP("");
                while (s.Read() && s.NodeType != System.Xml.XmlNodeType.EndElement && s.LocalName != oldName)
                {
                    if (s.NodeType == System.Xml.XmlNodeType.Text || s.NodeType == System.Xml.XmlNodeType.CDATA)
                        tnPart.Value += s.Value;
                    else if (s.NodeType == System.Xml.XmlNodeType.Element)
                        result.AddResultDetail(new NotImplementedElementResultDetail(ResultDetailType.Warning,
                            s.LocalName,
                            s.NamespaceURI,
                            s.ToString(), null));
                }
                tn.Part.Add(tnPart);
            }

            return tn;
        }

        /// <summary>
        /// Gets the type that this formater handles.
        /// </summary>
        public override string HandlesType
        {
            get { return "TN"; }
        }

        /// <summary>
        /// Get the supported properties for the rendering
        /// </summary>
        public List<PropertyInfo> GetSupportedProperties()
        {
            List<PropertyInfo> retVal = new List<PropertyInfo>(10);
            retVal.Add(typeof(TN).GetProperty("Part"));
            retVal.AddRange(new ANYFormatter().GetSupportedProperties());
            return retVal;
        }
        #endregion
    }
}
