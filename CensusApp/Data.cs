﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thedataweb.rm.census.gov/api/discovery/")]
[System.Xml.Serialization.XmlRootAttribute("census-api", Namespace = "http://thedataweb.rm.census.gov/api/discovery/", IsNullable = false)]
public partial class censusapi
{

    private censusapiVars[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("vars")]
    public censusapiVars[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thedataweb.rm.census.gov/api/discovery/")]
public partial class censusapiVars
{

    private censusapiVarsVar[] varField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("var")]
    public censusapiVarsVar[] var
    {
        get
        {
            return this.varField;
        }
        set
        {
            this.varField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thedataweb.rm.census.gov/api/discovery/")]
public partial class censusapiVarsVar
{

    private string labelField;

    private string conceptField;

    private string predicatetypeField;

    private string predicateonlyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string concept
    {
        get
        {
            return this.conceptField;
        }
        set
        {
            this.conceptField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("predicate-type")]
    public string predicatetype
    {
        get
        {
            return this.predicatetypeField;
        }
        set
        {
            this.predicatetypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("predicate-only")]
    public string predicateonly
    {
        get
        {
            return this.predicateonlyField;
        }
        set
        {
            this.predicateonlyField = value;
        }
    }
}
