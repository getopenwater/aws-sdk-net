/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the possible values for a configuration option.
    /// </summary>
    public partial class ConfigurationOptionDescription
    {
        private string _changeSeverity;
        private string _defaultValue;
        private int? _maxLength;
        private int? _maxValue;
        private int? _minValue;
        private string _name;
        private string _namespace;
        private OptionRestrictionRegex _regex;
        private bool? _userDefined;
        private List<string> _valueOptions = new List<string>();
        private string _valueType;


        /// <summary>
        /// Gets and sets the property ChangeSeverity. 
        /// <para>
        ///          An indication of which action is required if the value for this         configuration
        /// option changes:        
        /// </para>
        ///       <enumValues>         <value name="NoInterruption">            
        /// <para>
        ///                NoInterruption - There is no interruption to the               environment
        /// or application availability.                
        /// </para>
        ///          </value>         <value name="RestartEnvironment">            
        /// <para>
        ///                RestartEnvironment - The environment is               restarted, all
        /// AWS resources are deleted and recreated, and               the environment is unavailable
        /// during the process.                
        /// </para>
        ///          </value>         <value name="RestartApplicationServer">            
        /// <para>
        ///                RestartApplicationServer - The environment is available           
        ///    the entire time. However, a short application               outage occurs when
        /// the application servers on the running Amazon EC2 instances               are restarted.                
        /// </para>
        ///          </value>      </enumValues>      <ul>         <li>            <code>NoInterruption</code>
        ///            : There is no interruption to the            environment or application
        /// availability.         </li>         <li>            <code>RestartEnvironment</code>
        ///            : The environment is entirely            restarted, all AWS resources are
        /// deleted and recreated, and            the environment is unavailable during the process.
        ///         </li>         <li>            <code>RestartApplicationServer</code>      
        ///      : The environment is available            the entire time. However, a short application
        /// outage occurs when             the application servers on the running Amazon EC2 instances
        ///               are restarted.         </li>      </ul>
        /// </summary>
        public string ChangeSeverity
        {
            get { return this._changeSeverity; }
            set { this._changeSeverity = value; }
        }


        /// <summary>
        /// Sets the ChangeSeverity property
        /// </summary>
        /// <param name="changeSeverity">The value to set for the ChangeSeverity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithChangeSeverity(string changeSeverity)
        {
            this._changeSeverity = changeSeverity;
            return this;
        }

        // Check to see if ChangeSeverity property is set
        internal bool IsSetChangeSeverity()
        {
            return this._changeSeverity != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        ///          The default value for this configuration option.        
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }


        /// <summary>
        /// Sets the DefaultValue property
        /// </summary>
        /// <param name="defaultValue">The value to set for the DefaultValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithDefaultValue(string defaultValue)
        {
            this._defaultValue = defaultValue;
            return this;
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }


        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        ///          If specified, the configuration option must be a string value no longer than
        ///         this value.        
        /// </para>
        /// </summary>
        public int MaxLength
        {
            get { return this._maxLength.GetValueOrDefault(); }
            set { this._maxLength = value; }
        }


        /// <summary>
        /// Sets the MaxLength property
        /// </summary>
        /// <param name="maxLength">The value to set for the MaxLength property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithMaxLength(int maxLength)
        {
            this._maxLength = maxLength;
            return this;
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        ///          If specified, the configuration option must be a numeric value less than
        /// this         value.        
        /// </para>
        /// </summary>
        public int MaxValue
        {
            get { return this._maxValue.GetValueOrDefault(); }
            set { this._maxValue = value; }
        }


        /// <summary>
        /// Sets the MaxValue property
        /// </summary>
        /// <param name="maxValue">The value to set for the MaxValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithMaxValue(int maxValue)
        {
            this._maxValue = maxValue;
            return this;
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        ///          If specified, the configuration option must be a numeric value         greater
        /// than this value.        
        /// </para>
        /// </summary>
        public int MinValue
        {
            get { return this._minValue.GetValueOrDefault(); }
            set { this._minValue = value; }
        }


        /// <summary>
        /// Sets the MinValue property
        /// </summary>
        /// <param name="minValue">The value to set for the MinValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithMinValue(int minValue)
        {
            this._minValue = minValue;
            return this;
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///          The name of the configuration option.        
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        ///          A unique namespace identifying the option's associated AWS resource.        
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }


        /// <summary>
        /// Sets the Namespace property
        /// </summary>
        /// <param name="ns">The value to set for the Namespace property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithNamespace(string ns)
        {
            this._namespace = ns;
            return this;
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._namespace != null;
        }


        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        ///          If specified, the configuration option must be a string value that satisfies
        ///         this regular expression.        
        /// </para>
        /// </summary>
        public OptionRestrictionRegex Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }


        /// <summary>
        /// Sets the Regex property
        /// </summary>
        /// <param name="regex">The value to set for the Regex property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithRegex(OptionRestrictionRegex regex)
        {
            this._regex = regex;
            return this;
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }


        /// <summary>
        /// Gets and sets the property UserDefined. 
        /// <para>
        ///          An indication of whether the user defined this configuration option:        
        /// </para>
        ///       <enumValues>         <value name="true">            
        /// <para>
        ///                <code>true</code>               : This configuration option was defined
        /// by the user. It is a               valid choice for specifying this as an Option to
        /// Remove when               updating configuration settings.            
        /// </para>
        ///          </value>         <value name="false">            
        /// <para>
        ///                <code>false</code>               : This configuration was not defined
        /// by the user.            
        /// </para>
        ///          </value>      </enumValues>      <ul>         <li>            
        /// <para>
        ///                <code>true</code>               : This configuration option was defined
        /// by the user. It is a               valid choice for specifying if this as an     
        ///          <code>Option to Remove</code>               when               updating configuration
        /// settings.            
        /// </para>
        ///          </li>         <li>            <code>false</code>            : This configuration
        /// was not defined by the user.         </li>      </ul>      
        /// <para>
        ///          Constraint: You can remove only <code>UserDefined</code>         options
        /// from a configuration.      
        /// </para>
        ///       
        /// <para>
        ///       Valid Values: <code>true</code> | <code>false</code>
        /// </para>
        /// </summary>
        public bool UserDefined
        {
            get { return this._userDefined.GetValueOrDefault(); }
            set { this._userDefined = value; }
        }


        /// <summary>
        /// Sets the UserDefined property
        /// </summary>
        /// <param name="userDefined">The value to set for the UserDefined property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithUserDefined(bool userDefined)
        {
            this._userDefined = userDefined;
            return this;
        }

        // Check to see if UserDefined property is set
        internal bool IsSetUserDefined()
        {
            return this._userDefined.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ValueOptions. 
        /// <para>
        ///          If specified, values for the configuration option are selected         from
        /// this list.        
        /// </para>
        /// </summary>
        public List<string> ValueOptions
        {
            get { return this._valueOptions; }
            set { this._valueOptions = value; }
        }

        /// <summary>
        /// Sets the ValueOptions property
        /// </summary>
        /// <param name="valueOptions">The values to add to the ValueOptions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithValueOptions(params string[] valueOptions)
        {
            foreach (var element in valueOptions)
            {
                this._valueOptions.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ValueOptions property
        /// </summary>
        /// <param name="valueOptions">The values to add to the ValueOptions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithValueOptions(IEnumerable<string> valueOptions)
        {
            foreach (var element in valueOptions)
            {
                this._valueOptions.Add(element);
            }
            return this;
        }
        // Check to see if ValueOptions property is set
        internal bool IsSetValueOptions()
        {
            return this._valueOptions != null && this._valueOptions.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        ///          An indication of which type of values this option has and whether       
        ///  it is allowable to select one or more than one of the possible values:        
        /// </para>
        ///       <enumValues>         <value name="Scalar">            
        /// <para>
        ///                <code>Scalar</code>               : Values for this option are a single
        /// selection from the               possible values, or a unformatted string or numeric
        /// value governed               by the MIN/MAX/Regex constraints:            
        /// </para>
        ///          </value>         <value name="List">            
        /// <para>
        ///                <code>List</code>               : Values for this option are multiple
        /// selections of the               possible values.            
        /// </para>
        ///          </value>         <value name="Boolean">            
        /// <para>
        ///                <code>Boolean</code>               : Values for this option are either
        ///               <code>true</code>               or               <code>false</code>
        ///               .            
        /// </para>
        ///          </value>      </enumValues>      
        /// <para>
        ///          <ul>            <li>               <code>Scalar</code>               : Values
        /// for this option are a single selection from the               possible values, or
        /// an unformatted string, or numeric value governed               by the <code>MIN/MAX/Regex</code>
        /// constraints.            </li>            <li>               <code>List</code>    
        ///           : Values for this option are multiple selections from the              
        /// possible values.            </li>            <li>               <code>Boolean</code>
        ///               : Values for this option are either               <code>true</code>
        ///               or               <code>false</code>               .            </li>
        ///         </ul>      
        /// </para>
        /// </summary>
        public string ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }


        /// <summary>
        /// Sets the ValueType property
        /// </summary>
        /// <param name="valueType">The value to set for the ValueType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionDescription WithValueType(string valueType)
        {
            this._valueType = valueType;
            return this;
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

    }
}