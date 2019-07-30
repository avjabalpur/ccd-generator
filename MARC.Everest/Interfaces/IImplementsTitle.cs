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
 * User: Justin Fyfe
 * Date: 11-11-2011
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MARC.Everest.DataTypes;

namespace MARC.Everest.Interfaces
{
    /// <summary>
    /// Identifies a class that has a "Title" property
    /// </summary>
    /// <remarks>GPMR will append this interface to any RMIM structure that has
    /// identified a property named Title with the data type ST</remarks>
    public interface IImplementsTitle : IGraphable
    {

        /// <summary>
        /// Gets or sets the title of the structure
        /// </summary>
        ST Title { get; set;  }
    }
}
