﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Presentation;

namespace DocumentFormat.OpenXml.Vml
{
/// <summary>
/// <para>Defines the Path Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:path.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Path : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12577;
    /// <inheritdoc/>
    public override string LocalName => "path";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Path Definition.</para>
    /// <para>Represents the following attribute in the schema: v </para>
    /// </summary>
    [SchemaAttr(0, "v")]
    [SchemaIndex(1)]
    public StringValue Value { get; set; }
    /// <summary>
    /// <para> Limo Stretch Point.</para>
    /// <para>Represents the following attribute in the schema: limo </para>
    /// </summary>
    [SchemaAttr(0, "limo")]
    [SchemaIndex(2)]
    public StringValue Limo { get; set; }
    /// <summary>
    /// <para> Text Box Bounding Box.</para>
    /// <para>Represents the following attribute in the schema: textboxrect </para>
    /// </summary>
    [SchemaAttr(0, "textboxrect")]
    [SchemaIndex(3)]
    public StringValue TextboxRectangle { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fillok </para>
    /// </summary>
    [SchemaAttr(0, "fillok")]
    [SchemaIndex(4)]
    public TrueFalseValue AllowFill { get; set; }
    /// <summary>
    /// <para> Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: strokeok </para>
    /// </summary>
    [SchemaAttr(0, "strokeok")]
    [SchemaIndex(5)]
    public TrueFalseValue AllowStroke { get; set; }
    /// <summary>
    /// <para> Shadow Toggle.</para>
    /// <para>Represents the following attribute in the schema: shadowok </para>
    /// </summary>
    [SchemaAttr(0, "shadowok")]
    [SchemaIndex(6)]
    public TrueFalseValue AllowShading { get; set; }
    /// <summary>
    /// <para> Arrowhead Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: arrowok </para>
    /// </summary>
    [SchemaAttr(0, "arrowok")]
    [SchemaIndex(7)]
    public TrueFalseValue ShowArrowhead { get; set; }
    /// <summary>
    /// <para> Gradient Shape Toggle.</para>
    /// <para>Represents the following attribute in the schema: gradientshapeok </para>
    /// </summary>
    [SchemaAttr(0, "gradientshapeok")]
    [SchemaIndex(8)]
    public TrueFalseValue AllowGradientShape { get; set; }
    /// <summary>
    /// <para> Text Path Toggle.</para>
    /// <para>Represents the following attribute in the schema: textpathok </para>
    /// </summary>
    [SchemaAttr(0, "textpathok")]
    [SchemaIndex(9)]
    public TrueFalseValue AllowTextPath { get; set; }
    /// <summary>
    /// <para> Inset Stroke From Path Flag.</para>
    /// <para>Represents the following attribute in the schema: insetpenok </para>
    /// </summary>
    [SchemaAttr(0, "insetpenok")]
    [SchemaIndex(10)]
    public TrueFalseValue AllowInsetPen { get; set; }
    /// <summary>
    /// <para> Connection Point Type.</para>
    /// <para>Represents the following attribute in the schema: o:connecttype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connecttype")]
    [SchemaIndex(11)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues> ConnectionPointType { get; set; }
    /// <summary>
    /// <para> Connection Points.</para>
    /// <para>Represents the following attribute in the schema: o:connectlocs </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectlocs")]
    [SchemaIndex(12)]
    public StringValue ConnectionPoints { get; set; }
    /// <summary>
    /// <para> Connection Point Connect Angles.</para>
    /// <para>Represents the following attribute in the schema: o:connectangles </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectangles")]
    [SchemaIndex(13)]
    public StringValue ConnectAngles { get; set; }
    /// <summary>
    /// <para> Extrusion Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:extrusionok </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "extrusionok")]
    [SchemaIndex(14)]
    public TrueFalseValue AllowExtrusion { get; set; }

    /// <summary>
    /// Initializes a new instance of the Path class.
    /// </summary>
    public Path():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Path>(deep);

}
/// <summary>
/// <para>Defines the Formulas Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:formulas.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;v:f></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Formulas : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12578;
    /// <inheritdoc/>
    public override string LocalName => "formulas";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the Formulas class.
    /// </summary>
    public Formulas():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Formulas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Formulas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Formulas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Formulas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Formulas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Formulas(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "f" == name)
    return new Formula();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formulas>(deep);

}
/// <summary>
/// <para>Defines the ShapeHandles Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:handles.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeHandle &lt;v:h></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeHandle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeHandles : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12579;
    /// <inheritdoc/>
    public override string LocalName => "handles";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ShapeHandles class.
    /// </summary>
    public ShapeHandles():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShapeHandles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeHandles(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeHandles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeHandles(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeHandles class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeHandles(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "h" == name)
    return new ShapeHandle();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandles>(deep);

}
/// <summary>
/// <para>Defines the Fill Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:fill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties &lt;o:fill></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Fill : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12580;
    /// <inheritdoc/>
    public override string LocalName => "fill";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Fill Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [SchemaIndex(1)]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues> Type { get; set; }
    /// <summary>
    /// <para> Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    [SchemaIndex(2)]
    public TrueFalseValue On { get; set; }
    /// <summary>
    /// <para> Primary Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    [SchemaIndex(3)]
    public StringValue Color { get; set; }
    /// <summary>
    /// <para> Primary Color Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    [SchemaIndex(4)]
    public StringValue Opacity { get; set; }
    /// <summary>
    /// <para> Secondary Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    [SchemaIndex(5)]
    public StringValue Color2 { get; set; }
    /// <summary>
    /// <para> Fill Image Source.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    [SchemaIndex(6)]
    public StringValue Source { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: o:href </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "href")]
    [SchemaIndex(7)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Alternate Image Reference Location.</para>
    /// <para>Represents the following attribute in the schema: o:althref </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "althref")]
    [SchemaIndex(8)]
    public StringValue AlternateImageReference { get; set; }
    /// <summary>
    /// <para> Fill Image Size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    [SchemaIndex(9)]
    public StringValue Size { get; set; }
    /// <summary>
    /// <para> Fill Image Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
    [SchemaIndex(10)]
    public StringValue Origin { get; set; }
    /// <summary>
    /// <para> Fill Image Position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    [SchemaIndex(11)]
    public StringValue Position { get; set; }
    /// <summary>
    /// <para> Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: aspect </para>
    /// </summary>
    [SchemaAttr(0, "aspect")]
    [SchemaIndex(12)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> Aspect { get; set; }
    /// <summary>
    /// <para> Intermediate Colors.</para>
    /// <para>Represents the following attribute in the schema: colors </para>
    /// </summary>
    [SchemaAttr(0, "colors")]
    [SchemaIndex(13)]
    public StringValue Colors { get; set; }
    /// <summary>
    /// <para> Gradient Angle.</para>
    /// <para>Represents the following attribute in the schema: angle </para>
    /// </summary>
    [SchemaAttr(0, "angle")]
    [SchemaIndex(14)]
    public DecimalValue Angle { get; set; }
    /// <summary>
    /// <para> Align Image With Shape.</para>
    /// <para>Represents the following attribute in the schema: alignshape </para>
    /// </summary>
    [SchemaAttr(0, "alignshape")]
    [SchemaIndex(15)]
    public TrueFalseValue AlignShape { get; set; }
    /// <summary>
    /// <para> Gradient Center.</para>
    /// <para>Represents the following attribute in the schema: focus </para>
    /// </summary>
    [SchemaAttr(0, "focus")]
    [SchemaIndex(16)]
    public StringValue Focus { get; set; }
    /// <summary>
    /// <para> Radial Gradient Size.</para>
    /// <para>Represents the following attribute in the schema: focussize </para>
    /// </summary>
    [SchemaAttr(0, "focussize")]
    [SchemaIndex(17)]
    public StringValue FocusSize { get; set; }
    /// <summary>
    /// <para> Radial Gradient Center.</para>
    /// <para>Represents the following attribute in the schema: focusposition </para>
    /// </summary>
    [SchemaAttr(0, "focusposition")]
    [SchemaIndex(18)]
    public StringValue FocusPosition { get; set; }
    /// <summary>
    /// <para> Gradient Fill Method.</para>
    /// <para>Represents the following attribute in the schema: method </para>
    /// </summary>
    [SchemaAttr(0, "method")]
    [SchemaIndex(19)]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues> Method { get; set; }
    /// <summary>
    /// <para> Detect Mouse Click.</para>
    /// <para>Represents the following attribute in the schema: o:detectmouseclick </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "detectmouseclick")]
    [SchemaIndex(20)]
    public TrueFalseValue DetectMouseClick { get; set; }
    /// <summary>
    /// <para> Title.</para>
    /// <para>Represents the following attribute in the schema: o:title </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "title")]
    [SchemaIndex(21)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Secondary Color Opacity.</para>
    /// <para>Represents the following attribute in the schema: o:opacity2 </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "opacity2")]
    [SchemaIndex(22)]
    public StringValue Opacity2 { get; set; }
    /// <summary>
    /// <para> Recolor Fill as Picture.</para>
    /// <para>Represents the following attribute in the schema: recolor </para>
    /// </summary>
    [SchemaAttr(0, "recolor")]
    [SchemaIndex(23)]
    public TrueFalseValue Recolor { get; set; }
    /// <summary>
    /// <para> Rotate Fill with Shape.</para>
    /// <para>Represents the following attribute in the schema: rotate </para>
    /// </summary>
    [SchemaAttr(0, "rotate")]
    [SchemaIndex(24)]
    public TrueFalseValue Rotate { get; set; }
    /// <summary>
    /// <para> Relationship to Part.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [SchemaIndex(25)]
    public StringValue RelationshipId { get; set; }

    /// <summary>
    /// Initializes a new instance of the Fill class.
    /// </summary>
    public Fill():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Fill class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Fill(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Fill class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Fill(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Fill class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Fill(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "fill" == name)
    return new DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fill" };
    private static readonly byte[] eleNamespaceIds = { 27 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FillExtendedProperties.</para>
    /// <para> Represents the following element tag in the schema: o:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties FillExtendedProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Fill>(deep);

}
/// <summary>
/// <para>Defines the Stroke Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:stroke.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Vml.Office.LeftStroke &lt;o:left></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.TopStroke &lt;o:top></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.RightStroke &lt;o:right></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.BottomStroke &lt;o:bottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ColumnStroke &lt;o:column></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.LeftStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.TopStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.RightStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.BottomStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ColumnStroke))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Stroke : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12581;
    /// <inheritdoc/>
    public override string LocalName => "stroke";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    [SchemaIndex(1)]
    public TrueFalseValue On { get; set; }
    /// <summary>
    /// <para> Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: weight </para>
    /// </summary>
    [SchemaAttr(0, "weight")]
    [SchemaIndex(2)]
    public StringValue Weight { get; set; }
    /// <summary>
    /// <para> Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    [SchemaIndex(3)]
    public StringValue Color { get; set; }
    /// <summary>
    /// <para> Stroke Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    [SchemaIndex(4)]
    public StringValue Opacity { get; set; }
    /// <summary>
    /// <para> Stroke Line Style.</para>
    /// <para>Represents the following attribute in the schema: linestyle </para>
    /// </summary>
    [SchemaAttr(0, "linestyle")]
    [SchemaIndex(5)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues> LineStyle { get; set; }
    /// <summary>
    /// <para> Miter Joint Limit.</para>
    /// <para>Represents the following attribute in the schema: miterlimit </para>
    /// </summary>
    [SchemaAttr(0, "miterlimit")]
    [SchemaIndex(6)]
    public StringValue Miterlimit { get; set; }
    /// <summary>
    /// <para> Line End Join Style.</para>
    /// <para>Represents the following attribute in the schema: joinstyle </para>
    /// </summary>
    [SchemaAttr(0, "joinstyle")]
    [SchemaIndex(7)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues> JoinStyle { get; set; }
    /// <summary>
    /// <para> Line End Cap.</para>
    /// <para>Represents the following attribute in the schema: endcap </para>
    /// </summary>
    [SchemaAttr(0, "endcap")]
    [SchemaIndex(8)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues> EndCap { get; set; }
    /// <summary>
    /// <para> Stroke Dash Pattern.</para>
    /// <para>Represents the following attribute in the schema: dashstyle </para>
    /// </summary>
    [SchemaAttr(0, "dashstyle")]
    [SchemaIndex(9)]
    public StringValue DashStyle { get; set; }
    /// <summary>
    /// <para> Stroke Image Style.</para>
    /// <para>Represents the following attribute in the schema: filltype </para>
    /// </summary>
    [SchemaAttr(0, "filltype")]
    [SchemaIndex(10)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues> FillType { get; set; }
    /// <summary>
    /// <para> Stroke Image Location.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    [SchemaIndex(11)]
    public StringValue Source { get; set; }
    /// <summary>
    /// <para> Stroke Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: imageaspect </para>
    /// </summary>
    [SchemaAttr(0, "imageaspect")]
    [SchemaIndex(12)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> ImageAspect { get; set; }
    /// <summary>
    /// <para> Stroke Image Size.</para>
    /// <para>Represents the following attribute in the schema: imagesize </para>
    /// </summary>
    [SchemaAttr(0, "imagesize")]
    [SchemaIndex(13)]
    public StringValue ImageSize { get; set; }
    /// <summary>
    /// <para> Stoke Image Alignment.</para>
    /// <para>Represents the following attribute in the schema: imagealignshape </para>
    /// </summary>
    [SchemaAttr(0, "imagealignshape")]
    [SchemaIndex(14)]
    public TrueFalseValue ImageAlignShape { get; set; }
    /// <summary>
    /// <para> Stroke Alternate Pattern Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    [SchemaIndex(15)]
    public StringValue Color2 { get; set; }
    /// <summary>
    /// <para> Line Start Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: startarrow </para>
    /// </summary>
    [SchemaAttr(0, "startarrow")]
    [SchemaIndex(16)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> StartArrow { get; set; }
    /// <summary>
    /// <para> Line Start Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: startarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "startarrowwidth")]
    [SchemaIndex(17)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> StartArrowWidth { get; set; }
    /// <summary>
    /// <para> Line Start Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: startarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "startarrowlength")]
    [SchemaIndex(18)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> StartArrowLength { get; set; }
    /// <summary>
    /// <para> Line End Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: endarrow </para>
    /// </summary>
    [SchemaAttr(0, "endarrow")]
    [SchemaIndex(19)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> EndArrow { get; set; }
    /// <summary>
    /// <para> Line End Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: endarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "endarrowwidth")]
    [SchemaIndex(20)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> EndArrowWidth { get; set; }
    /// <summary>
    /// <para> Line End Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: endarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "endarrowlength")]
    [SchemaIndex(21)]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> EndArrowLength { get; set; }
    /// <summary>
    /// <para> Original Image Reference.</para>
    /// <para>Represents the following attribute in the schema: o:href </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "href")]
    [SchemaIndex(22)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Alternate Image Reference.</para>
    /// <para>Represents the following attribute in the schema: o:althref </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "althref")]
    [SchemaIndex(23)]
    public StringValue AlternateImageReference { get; set; }
    /// <summary>
    /// <para> Stroke Title.</para>
    /// <para>Represents the following attribute in the schema: o:title </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "title")]
    [SchemaIndex(24)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(25)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Relationship.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [SchemaIndex(26)]
    public StringValue RelationshipId { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(27)]
    public TrueFalseValue Insetpen { get; set; }

    /// <summary>
    /// Initializes a new instance of the Stroke class.
    /// </summary>
    public Stroke():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Stroke class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Stroke(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Stroke class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Stroke(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Stroke class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Stroke(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "left" == name)
    return new DocumentFormat.OpenXml.Vml.Office.LeftStroke();
    
if( 27 == namespaceId && "top" == name)
    return new DocumentFormat.OpenXml.Vml.Office.TopStroke();
    
if( 27 == namespaceId && "right" == name)
    return new DocumentFormat.OpenXml.Vml.Office.RightStroke();
    
if( 27 == namespaceId && "bottom" == name)
    return new DocumentFormat.OpenXml.Vml.Office.BottomStroke();
    
if( 27 == namespaceId && "column" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ColumnStroke();
    

    return null;
}

        private static readonly string[] eleTagNames = { "left","top","right","bottom","column" };
    private static readonly byte[] eleNamespaceIds = { 27,27,27,27,27 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> LeftStroke.</para>
    /// <para> Represents the following element tag in the schema: o:left </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.LeftStroke LeftStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.LeftStroke>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> TopStroke.</para>
    /// <para> Represents the following element tag in the schema: o:top </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.TopStroke TopStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.TopStroke>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> RightStroke.</para>
    /// <para> Represents the following element tag in the schema: o:right </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.RightStroke RightStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.RightStroke>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> BottomStroke.</para>
    /// <para> Represents the following element tag in the schema: o:bottom </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.BottomStroke BottomStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.BottomStroke>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> ColumnStroke.</para>
    /// <para> Represents the following element tag in the schema: o:column </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.ColumnStroke ColumnStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Stroke>(deep);

}
/// <summary>
/// <para>Defines the Shadow Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:shadow.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shadow : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12582;
    /// <inheritdoc/>
    public override string LocalName => "shadow";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shadow Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    [SchemaIndex(1)]
    public TrueFalseValue On { get; set; }
    /// <summary>
    /// <para> Shadow Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [SchemaIndex(2)]
    public EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues> Type { get; set; }
    /// <summary>
    /// <para> Shadow Transparency.</para>
    /// <para>Represents the following attribute in the schema: obscured </para>
    /// </summary>
    [SchemaAttr(0, "obscured")]
    [SchemaIndex(3)]
    public TrueFalseValue Obscured { get; set; }
    /// <summary>
    /// <para> Shadow Primary Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    [SchemaIndex(4)]
    public StringValue Color { get; set; }
    /// <summary>
    /// <para> Shadow Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    [SchemaIndex(5)]
    public StringValue Opacity { get; set; }
    /// <summary>
    /// <para> Shadow Primary Offset.</para>
    /// <para>Represents the following attribute in the schema: offset </para>
    /// </summary>
    [SchemaAttr(0, "offset")]
    [SchemaIndex(6)]
    public StringValue Offset { get; set; }
    /// <summary>
    /// <para> Shadow Secondary Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    [SchemaIndex(7)]
    public StringValue Color2 { get; set; }
    /// <summary>
    /// <para> Shadow Secondary Offset.</para>
    /// <para>Represents the following attribute in the schema: offset2 </para>
    /// </summary>
    [SchemaAttr(0, "offset2")]
    [SchemaIndex(8)]
    public StringValue Offset2 { get; set; }
    /// <summary>
    /// <para> Shadow Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
    [SchemaIndex(9)]
    public StringValue Origin { get; set; }
    /// <summary>
    /// <para> Shadow Perspective Matrix.</para>
    /// <para>Represents the following attribute in the schema: matrix </para>
    /// </summary>
    [SchemaAttr(0, "matrix")]
    [SchemaIndex(10)]
    public StringValue Matrix { get; set; }

    /// <summary>
    /// Initializes a new instance of the Shadow class.
    /// </summary>
    public Shadow():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shadow>(deep);

}
/// <summary>
/// <para>Defines the TextBox Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:textbox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Wordprocessing.TextBoxContent &lt;w:txbxContent></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxContent))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TextBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12583;
    /// <inheritdoc/>
    public override string LocalName => "textbox";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Text Box Inset.</para>
    /// <para>Represents the following attribute in the schema: inset </para>
    /// </summary>
    [SchemaAttr(0, "inset")]
    [SchemaIndex(2)]
    public StringValue Inset { get; set; }
    /// <summary>
    /// <para> Text Box Single-Click Selection Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:singleclick </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "singleclick")]
    [SchemaIndex(3)]
    public TrueFalseValue SingleClick { get; set; }

    /// <summary>
    /// Initializes a new instance of the TextBox class.
    /// </summary>
    public TextBox():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TextBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "txbxContent" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.TextBoxContent();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBox>(deep);

}
/// <summary>
/// <para>Defines the TextPath Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:textpath.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TextPath : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12584;
    /// <inheritdoc/>
    public override string LocalName => "textpath";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Text Path Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    [SchemaIndex(2)]
    public TrueFalseValue On { get; set; }
    /// <summary>
    /// <para> Shape Fit Toggle.</para>
    /// <para>Represents the following attribute in the schema: fitshape </para>
    /// </summary>
    [SchemaAttr(0, "fitshape")]
    [SchemaIndex(3)]
    public TrueFalseValue FitShape { get; set; }
    /// <summary>
    /// <para> Path Fit Toggle.</para>
    /// <para>Represents the following attribute in the schema: fitpath </para>
    /// </summary>
    [SchemaAttr(0, "fitpath")]
    [SchemaIndex(4)]
    public TrueFalseValue FitPath { get; set; }
    /// <summary>
    /// <para> Text Path Trim Toggle.</para>
    /// <para>Represents the following attribute in the schema: trim </para>
    /// </summary>
    [SchemaAttr(0, "trim")]
    [SchemaIndex(5)]
    public TrueFalseValue Trim { get; set; }
    /// <summary>
    /// <para> Text X-Scaling.</para>
    /// <para>Represents the following attribute in the schema: xscale </para>
    /// </summary>
    [SchemaAttr(0, "xscale")]
    [SchemaIndex(6)]
    public TrueFalseValue XScale { get; set; }
    /// <summary>
    /// <para> Text Path Text.</para>
    /// <para>Represents the following attribute in the schema: string </para>
    /// </summary>
    [SchemaAttr(0, "string")]
    [SchemaIndex(7)]
    public StringValue String { get; set; }

    /// <summary>
    /// Initializes a new instance of the TextPath class.
    /// </summary>
    public TextPath():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextPath>(deep);

}
/// <summary>
/// <para>Defines the ImageData Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:imagedata.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ImageData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12585;
    /// <inheritdoc/>
    public override string LocalName => "imagedata";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Image Transparency Color.</para>
    /// <para>Represents the following attribute in the schema: chromakey </para>
    /// </summary>
    [SchemaAttr(0, "chromakey")]
    [SchemaIndex(1)]
    public StringValue ChromAKey { get; set; }
    /// <summary>
    /// <para> Image Left Crop.</para>
    /// <para>Represents the following attribute in the schema: cropleft </para>
    /// </summary>
    [SchemaAttr(0, "cropleft")]
    [SchemaIndex(2)]
    public StringValue CropLeft { get; set; }
    /// <summary>
    /// <para> Image Top Crop.</para>
    /// <para>Represents the following attribute in the schema: croptop </para>
    /// </summary>
    [SchemaAttr(0, "croptop")]
    [SchemaIndex(3)]
    public StringValue CropTop { get; set; }
    /// <summary>
    /// <para> Image Right Crop.</para>
    /// <para>Represents the following attribute in the schema: cropright </para>
    /// </summary>
    [SchemaAttr(0, "cropright")]
    [SchemaIndex(4)]
    public StringValue CropRight { get; set; }
    /// <summary>
    /// <para> Image Bottom Crop.</para>
    /// <para>Represents the following attribute in the schema: cropbottom </para>
    /// </summary>
    [SchemaAttr(0, "cropbottom")]
    [SchemaIndex(5)]
    public StringValue CropBottom { get; set; }
    /// <summary>
    /// <para> Image Intensity.</para>
    /// <para>Represents the following attribute in the schema: gain </para>
    /// </summary>
    [SchemaAttr(0, "gain")]
    [SchemaIndex(6)]
    public StringValue Gain { get; set; }
    /// <summary>
    /// <para> Image Brightness.</para>
    /// <para>Represents the following attribute in the schema: blacklevel </para>
    /// </summary>
    [SchemaAttr(0, "blacklevel")]
    [SchemaIndex(7)]
    public StringValue BlackLevel { get; set; }
    /// <summary>
    /// <para> Image Gamma Correction.</para>
    /// <para>Represents the following attribute in the schema: gamma </para>
    /// </summary>
    [SchemaAttr(0, "gamma")]
    [SchemaIndex(8)]
    public StringValue Gamma { get; set; }
    /// <summary>
    /// <para> Image Grayscale Toggle.</para>
    /// <para>Represents the following attribute in the schema: grayscale </para>
    /// </summary>
    [SchemaAttr(0, "grayscale")]
    [SchemaIndex(9)]
    public TrueFalseValue Grayscale { get; set; }
    /// <summary>
    /// <para> Image Bilevel Toggle.</para>
    /// <para>Represents the following attribute in the schema: bilevel </para>
    /// </summary>
    [SchemaAttr(0, "bilevel")]
    [SchemaIndex(10)]
    public TrueFalseValue BiLevel { get; set; }
    /// <summary>
    /// <para> Embossed Color.</para>
    /// <para>Represents the following attribute in the schema: embosscolor </para>
    /// </summary>
    [SchemaAttr(0, "embosscolor")]
    [SchemaIndex(11)]
    public StringValue EmbossColor { get; set; }
    /// <summary>
    /// <para> Black Recoloring Color.</para>
    /// <para>Represents the following attribute in the schema: recolortarget </para>
    /// </summary>
    [SchemaAttr(0, "recolortarget")]
    [SchemaIndex(12)]
    public StringValue RecolorTarget { get; set; }
    /// <summary>
    /// <para> Image Data Title.</para>
    /// <para>Represents the following attribute in the schema: o:title </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "title")]
    [SchemaIndex(13)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Detect Mouse Click.</para>
    /// <para>Represents the following attribute in the schema: o:detectmouseclick </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "detectmouseclick")]
    [SchemaIndex(14)]
    public TrueFalseValue DetectMouseClick { get; set; }
    /// <summary>
    /// <para> Relationship to Part.</para>
    /// <para>Represents the following attribute in the schema: o:relid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "relid")]
    [SchemaIndex(15)]
    public StringValue RelId { get; set; }
    /// <summary>
    /// <para> Explicit Relationship to Image Data.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [SchemaIndex(16)]
    public StringValue RelationshipId { get; set; }
    /// <summary>
    /// <para> Explicit Relationship to Alternate Image Data.</para>
    /// <para>Represents the following attribute in the schema: r:pict </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "pict")]
    [SchemaIndex(17)]
    public StringValue Picture { get; set; }
    /// <summary>
    /// <para> Explicit Relationship to Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: r:href </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "href")]
    [SchemaIndex(18)]
    public StringValue RelHref { get; set; }

    /// <summary>
    /// Initializes a new instance of the ImageData class.
    /// </summary>
    public ImageData():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageData>(deep);

}
/// <summary>
/// <para>Shape Definition.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:shape.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Ink &lt;o:ink></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag &lt;pvml:iscomment></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Ink))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12586;
    /// <inheritdoc/>
    public override string LocalName => "shape";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(26)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(27)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(28)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(29)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(30)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(31)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(32)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(34)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(35)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(36)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(37)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(38)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(39)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(40)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(44)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(45)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(46)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(47)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(48)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(49)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(50)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Shape Type Reference.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [SchemaIndex(51)]
    public StringValue Type { get; set; }
    /// <summary>
    /// <para> Adjustment Parameters.</para>
    /// <para>Represents the following attribute in the schema: adj </para>
    /// </summary>
    [SchemaAttr(0, "adj")]
    [SchemaIndex(52)]
    public StringValue Adjustment { get; set; }
    /// <summary>
    /// <para> Edge Path.</para>
    /// <para>Represents the following attribute in the schema: path </para>
    /// </summary>
    [SchemaAttr(0, "path")]
    [SchemaIndex(53)]
    public StringValue EdgePath { get; set; }
    /// <summary>
    /// <para> Encoded Package.</para>
    /// <para>Represents the following attribute in the schema: o:gfxdata </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "gfxdata")]
    [SchemaIndex(54)]
    public Base64BinaryValue EncodedPackage { get; set; }
    /// <summary>
    /// <para> Storage for Alternate Math Content.</para>
    /// <para>Represents the following attribute in the schema: equationxml </para>
    /// </summary>
    [SchemaAttr(0, "equationxml")]
    [SchemaIndex(55)]
    public StringValue EquationXml { get; set; }

    /// <summary>
    /// Initializes a new instance of the Shape class.
    /// </summary>
    public Shape():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Shape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shape(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Shape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shape(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Shape class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Shape(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    
if( 27 == namespaceId && "ink" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Ink();
    
if( 30 == namespaceId && "iscomment" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);

}
/// <summary>
/// <para>Shape Template.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:shapetype.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Complex &lt;o:complex></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Complex))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shapetype : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12587;
    /// <inheritdoc/>
    public override string LocalName => "shapetype";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(26)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(27)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(28)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(29)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(30)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(31)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(32)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(34)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(35)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(36)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(37)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(38)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(39)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(40)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(44)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(45)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(46)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(47)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(48)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(49)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(50)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Adjustment Parameters.</para>
    /// <para>Represents the following attribute in the schema: adj </para>
    /// </summary>
    [SchemaAttr(0, "adj")]
    [SchemaIndex(51)]
    public StringValue Adjustment { get; set; }
    /// <summary>
    /// <para> Edge Path.</para>
    /// <para>Represents the following attribute in the schema: path </para>
    /// </summary>
    [SchemaAttr(0, "path")]
    [SchemaIndex(52)]
    public StringValue EdgePath { get; set; }
    /// <summary>
    /// <para> Master Element Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:master </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "master")]
    [SchemaIndex(53)]
    public StringValue Master { get; set; }

    /// <summary>
    /// Initializes a new instance of the Shapetype class.
    /// </summary>
    public Shapetype():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Shapetype class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shapetype(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Shapetype class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shapetype(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Shapetype class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Shapetype(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    
if( 27 == namespaceId && "complex" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Complex();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shapetype>(deep);

}
/// <summary>
/// <para>Shape Group.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Group &lt;v:group></description></item>
///<item><description>Shape &lt;v:shape></description></item>
///<item><description>Shapetype &lt;v:shapetype></description></item>
///<item><description>Arc &lt;v:arc></description></item>
///<item><description>Curve &lt;v:curve></description></item>
///<item><description>ImageFile &lt;v:image></description></item>
///<item><description>Line &lt;v:line></description></item>
///<item><description>Oval &lt;v:oval></description></item>
///<item><description>PolyLine &lt;v:polyline></description></item>
///<item><description>Rectangle &lt;v:rect></description></item>
///<item><description>RoundRectangle &lt;v:roundrect></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Diagram &lt;o:diagram></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(Shapetype))]
    [ChildElementInfo(typeof(Arc))]
    [ChildElementInfo(typeof(Curve))]
    [ChildElementInfo(typeof(ImageFile))]
    [ChildElementInfo(typeof(Line))]
    [ChildElementInfo(typeof(Oval))]
    [ChildElementInfo(typeof(PolyLine))]
    [ChildElementInfo(typeof(Rectangle))]
    [ChildElementInfo(typeof(RoundRectangle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Diagram))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Group : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12588;
    /// <inheritdoc/>
    public override string LocalName => "group";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> oned.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> regroupid.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> doubleclicknotify.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> button.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> userhidden.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> hr.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> hrstd.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> hrnoshade.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> hrpct.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> hralign.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> allowincell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> allowoverlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> userdrawn.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> dgmlayout.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(26)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> dgmnodekind.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(27)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> dgmlayoutmru.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(28)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> insetmode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(29)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Group Diagram Type.</para>
    /// <para>Represents the following attribute in the schema: editas </para>
    /// </summary>
    [SchemaAttr(0, "editas")]
    [SchemaIndex(30)]
    public EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues> EditAs { get; set; }
    /// <summary>
    /// <para> Table Properties.</para>
    /// <para>Represents the following attribute in the schema: o:tableproperties </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "tableproperties")]
    [SchemaIndex(31)]
    public StringValue TableProperties { get; set; }
    /// <summary>
    /// <para> Table Row Height Limits.</para>
    /// <para>Represents the following attribute in the schema: o:tablelimits </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "tablelimits")]
    [SchemaIndex(32)]
    public StringValue TableLimits { get; set; }

    /// <summary>
    /// Initializes a new instance of the Group class.
    /// </summary>
    public Group():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Group(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "group" == name)
    return new Group();
    
if( 26 == namespaceId && "shape" == name)
    return new Shape();
    
if( 26 == namespaceId && "shapetype" == name)
    return new Shapetype();
    
if( 26 == namespaceId && "arc" == name)
    return new Arc();
    
if( 26 == namespaceId && "curve" == name)
    return new Curve();
    
if( 26 == namespaceId && "image" == name)
    return new ImageFile();
    
if( 26 == namespaceId && "line" == name)
    return new Line();
    
if( 26 == namespaceId && "oval" == name)
    return new Oval();
    
if( 26 == namespaceId && "polyline" == name)
    return new PolyLine();
    
if( 26 == namespaceId && "rect" == name)
    return new Rectangle();
    
if( 26 == namespaceId && "roundrect" == name)
    return new RoundRectangle();
    
if( 27 == namespaceId && "diagram" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Diagram();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);

}
/// <summary>
/// <para>Document Background.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:background.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Fill &lt;v:fill></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Fill))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Background : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12589;
    /// <inheritdoc/>
    public override string LocalName => "background";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fill </para>
    /// </summary>
    [SchemaAttr(0, "fill")]
    [SchemaIndex(1)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(2)]
    public StringValue Fillcolor { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(3)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(4)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(5)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Target Screen Size.</para>
    /// <para>Represents the following attribute in the schema: o:targetscreensize </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "targetscreensize")]
    [SchemaIndex(6)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues> TargetScreenSize { get; set; }

    /// <summary>
    /// Initializes a new instance of the Background class.
    /// </summary>
    public Background():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Background class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Background(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Background class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Background(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Background class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Background(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "fill" == name)
    return new Fill();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fill" };
    private static readonly byte[] eleNamespaceIds = { 26 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Fill.</para>
    /// <para> Represents the following element tag in the schema: v:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public Fill Fill
    {
        get => GetElement<Fill>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Background>(deep);

}
/// <summary>
/// <para>Arc Segment.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:arc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Arc : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12590;
    /// <inheritdoc/>
    public override string LocalName => "arc";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(0)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(1)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(2)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(3)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(4)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(5)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(6)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(7)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(8)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(9)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(10)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(11)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(12)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(13)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(14)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(15)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(16)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(17)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(18)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(19)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(20)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(21)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(23)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(24)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(25)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(26)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(27)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(28)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(29)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(30)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(31)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(32)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(34)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(35)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(36)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(37)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(38)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(39)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(40)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(41)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(42)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(43)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(44)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(45)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(46)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(47)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(48)]
    public StringValue Wrapcoords { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(49)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Starting Angle.</para>
    /// <para>Represents the following attribute in the schema: startangle </para>
    /// </summary>
    [SchemaAttr(0, "startangle")]
    [SchemaIndex(50)]
    public DecimalValue StartAngle { get; set; }
    /// <summary>
    /// <para> Ending Angle.</para>
    /// <para>Represents the following attribute in the schema: endangle </para>
    /// </summary>
    [SchemaAttr(0, "endangle")]
    [SchemaIndex(51)]
    public DecimalValue EndAngle { get; set; }

    /// <summary>
    /// Initializes a new instance of the Arc class.
    /// </summary>
    public Arc():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Arc class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Arc(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Arc class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Arc(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Arc class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Arc(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Arc>(deep);

}
/// <summary>
/// <para>Bezier Curve.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:curve.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Curve : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12591;
    /// <inheritdoc/>
    public override string LocalName => "curve";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(26)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(27)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(28)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(29)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(30)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(31)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(32)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(34)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(35)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(36)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(37)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(38)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(39)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(40)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(44)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(45)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(46)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(47)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(48)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(49)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(50)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Curve Starting Point.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    [SchemaIndex(51)]
    public StringValue From { get; set; }
    /// <summary>
    /// <para> First Curve Control Point.</para>
    /// <para>Represents the following attribute in the schema: control1 </para>
    /// </summary>
    [SchemaAttr(0, "control1")]
    [SchemaIndex(52)]
    public StringValue Control1 { get; set; }
    /// <summary>
    /// <para> Second Curve Control Point.</para>
    /// <para>Represents the following attribute in the schema: control2 </para>
    /// </summary>
    [SchemaAttr(0, "control2")]
    [SchemaIndex(53)]
    public StringValue Control2 { get; set; }
    /// <summary>
    /// <para> Curve Ending Point.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    [SchemaIndex(54)]
    public StringValue To { get; set; }

    /// <summary>
    /// Initializes a new instance of the Curve class.
    /// </summary>
    public Curve():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Curve class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Curve(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Curve class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Curve(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Curve class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Curve(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Curve>(deep);

}
/// <summary>
/// <para>Image File.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:image.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ImageFile : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12592;
    /// <inheritdoc/>
    public override string LocalName => "image";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> class.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> alt.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> coordsize.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> wrapcoords.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(8)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> print.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(9)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(10)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(11)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(12)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(13)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(14)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(15)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(16)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(17)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(18)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(20)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(21)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(22)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(24)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(25)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(26)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(27)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(28)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(29)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(30)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(31)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(32)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(33)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(34)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(35)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(36)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(37)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(38)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(39)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(40)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(44)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(45)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(46)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(47)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(48)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(49)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Image Source.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    [SchemaIndex(50)]
    public StringValue Source { get; set; }
    /// <summary>
    /// <para> Image Left Crop.</para>
    /// <para>Represents the following attribute in the schema: cropleft </para>
    /// </summary>
    [SchemaAttr(0, "cropleft")]
    [SchemaIndex(51)]
    public StringValue CropLeft { get; set; }
    /// <summary>
    /// <para> Image Top Crop.</para>
    /// <para>Represents the following attribute in the schema: croptop </para>
    /// </summary>
    [SchemaAttr(0, "croptop")]
    [SchemaIndex(52)]
    public StringValue CropTop { get; set; }
    /// <summary>
    /// <para> Image Right Crop.</para>
    /// <para>Represents the following attribute in the schema: cropright </para>
    /// </summary>
    [SchemaAttr(0, "cropright")]
    [SchemaIndex(53)]
    public StringValue CropRight { get; set; }
    /// <summary>
    /// <para> Image Bottom Crop.</para>
    /// <para>Represents the following attribute in the schema: cropbottom </para>
    /// </summary>
    [SchemaAttr(0, "cropbottom")]
    [SchemaIndex(54)]
    public StringValue CropBottom { get; set; }
    /// <summary>
    /// <para> Image Intensity.</para>
    /// <para>Represents the following attribute in the schema: gain </para>
    /// </summary>
    [SchemaAttr(0, "gain")]
    [SchemaIndex(55)]
    public StringValue Gain { get; set; }
    /// <summary>
    /// <para> Image Brightness.</para>
    /// <para>Represents the following attribute in the schema: blacklevel </para>
    /// </summary>
    [SchemaAttr(0, "blacklevel")]
    [SchemaIndex(56)]
    public StringValue BlackLevel { get; set; }
    /// <summary>
    /// <para> Image Gamma Correction.</para>
    /// <para>Represents the following attribute in the schema: gamma </para>
    /// </summary>
    [SchemaAttr(0, "gamma")]
    [SchemaIndex(57)]
    public StringValue Gamma { get; set; }
    /// <summary>
    /// <para> Image Grayscale Toggle.</para>
    /// <para>Represents the following attribute in the schema: grayscale </para>
    /// </summary>
    [SchemaAttr(0, "grayscale")]
    [SchemaIndex(58)]
    public TrueFalseValue GrayScale { get; set; }
    /// <summary>
    /// <para> Image Bilevel Toggle.</para>
    /// <para>Represents the following attribute in the schema: bilevel </para>
    /// </summary>
    [SchemaAttr(0, "bilevel")]
    [SchemaIndex(59)]
    public TrueFalseValue BiLevel { get; set; }

    /// <summary>
    /// Initializes a new instance of the ImageFile class.
    /// </summary>
    public ImageFile():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ImageFile class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageFile(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageFile class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageFile(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageFile class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ImageFile(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageFile>(deep);

}
/// <summary>
/// <para>Line.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:line.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Line : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12593;
    /// <inheritdoc/>
    public override string LocalName => "line";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(26)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(27)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(28)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(29)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(30)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(31)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(32)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(34)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(35)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(36)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(37)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(38)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(39)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(40)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(44)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(45)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(46)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(47)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(48)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(49)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(50)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Line Start.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    [SchemaIndex(51)]
    public StringValue From { get; set; }
    /// <summary>
    /// <para> Line End Point.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    [SchemaIndex(52)]
    public StringValue To { get; set; }

    /// <summary>
    /// Initializes a new instance of the Line class.
    /// </summary>
    public Line():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Line class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Line class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Line class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Line(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line>(deep);

}
/// <summary>
/// <para>Oval.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:oval.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Oval : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12594;
    /// <inheritdoc/>
    public override string LocalName => "oval";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(26)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(27)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(28)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(29)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(30)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(31)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(32)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(34)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(35)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(36)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(37)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(38)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(39)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(40)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(44)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(45)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(46)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(47)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(48)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(49)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(50)]
    public TrueFalseValue Clip { get; set; }

    /// <summary>
    /// Initializes a new instance of the Oval class.
    /// </summary>
    public Oval():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Oval class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Oval(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Oval class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Oval(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Oval class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Oval(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Oval>(deep);

}
/// <summary>
/// <para>Multiple Path Line.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:polyline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Ink &lt;o:ink></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Ink))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PolyLine : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12595;
    /// <inheritdoc/>
    public override string LocalName => "polyline";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(26)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(27)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(28)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(29)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(30)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(31)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(32)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(34)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(35)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(36)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(37)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(38)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(39)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(40)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(44)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(45)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(46)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(47)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(48)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(49)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(50)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Points for Compound Line.</para>
    /// <para>Represents the following attribute in the schema: points </para>
    /// </summary>
    [SchemaAttr(0, "points")]
    [SchemaIndex(51)]
    public StringValue Points { get; set; }

    /// <summary>
    /// Initializes a new instance of the PolyLine class.
    /// </summary>
    public PolyLine():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PolyLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PolyLine(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PolyLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PolyLine(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PolyLine class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PolyLine(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    
if( 27 == namespaceId && "ink" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Ink();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PolyLine>(deep);

}
/// <summary>
/// <para>Rectangle.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:rect.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Rectangle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12596;
    /// <inheritdoc/>
    public override string LocalName => "rect";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    [SchemaIndex(8)]
    public StringValue CoordinateOrigin { get; set; }
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(9)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(10)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(11)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(12)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(13)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(14)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(15)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(16)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(17)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(18)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(20)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(21)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(22)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(24)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(25)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(26)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(27)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(28)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(29)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(30)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(31)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(32)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(33)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(34)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(35)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(36)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(37)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(38)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(39)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(40)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(44)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(45)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(46)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(47)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(48)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(49)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(50)]
    public TrueFalseValue Clip { get; set; }

    /// <summary>
    /// Initializes a new instance of the Rectangle class.
    /// </summary>
    public Rectangle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Rectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rectangle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Rectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rectangle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Rectangle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Rectangle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rectangle>(deep);

}
/// <summary>
/// <para>Rounded Rectangle.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:roundrect.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RoundRectangle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12597;
    /// <inheritdoc/>
    public override string LocalName => "roundrect";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [SchemaIndex(1)]
    public StringValue Style { get; set; }
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [SchemaIndex(2)]
    public StringValue Href { get; set; }
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [SchemaIndex(3)]
    public StringValue Target { get; set; }
    /// <summary>
    /// <para> class.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    [SchemaIndex(4)]
    public StringValue Class { get; set; }
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> alt.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    [SchemaIndex(6)]
    public StringValue Alternate { get; set; }
    /// <summary>
    /// <para> coordsize.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    [SchemaIndex(7)]
    public StringValue CoordinateSize { get; set; }
    /// <summary>
    /// <para> wrapcoords.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    [SchemaIndex(8)]
    public StringValue WrapCoordinates { get; set; }
    /// <summary>
    /// <para> print.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    [SchemaIndex(9)]
    public TrueFalseValue Print { get; set; }
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    [SchemaIndex(10)]
    public StringValue OptionalString { get; set; }
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    [SchemaIndex(11)]
    public TrueFalseValue Oned { get; set; }
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    [SchemaIndex(12)]
    public IntegerValue RegroupId { get; set; }
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    [SchemaIndex(13)]
    public TrueFalseValue DoubleClickNotify { get; set; }
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    [SchemaIndex(14)]
    public TrueFalseValue Button { get; set; }
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    [SchemaIndex(15)]
    public TrueFalseValue UserHidden { get; set; }
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    [SchemaIndex(16)]
    public TrueFalseValue Bullet { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    [SchemaIndex(17)]
    public TrueFalseValue Horizontal { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    [SchemaIndex(18)]
    public TrueFalseValue HorizontalStandard { get; set; }
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    [SchemaIndex(19)]
    public TrueFalseValue HorizontalNoShade { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    [SchemaIndex(20)]
    public SingleValue HorizontalPercentage { get; set; }
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    [SchemaIndex(21)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment { get; set; }
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    [SchemaIndex(22)]
    public TrueFalseValue AllowInCell { get; set; }
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    [SchemaIndex(23)]
    public TrueFalseValue AllowOverlap { get; set; }
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    [SchemaIndex(24)]
    public TrueFalseValue UserDrawn { get; set; }
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    [SchemaIndex(25)]
    public StringValue BorderTopColor { get; set; }
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    [SchemaIndex(26)]
    public StringValue BorderLeftColor { get; set; }
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    [SchemaIndex(27)]
    public StringValue BorderBottomColor { get; set; }
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    [SchemaIndex(28)]
    public StringValue BorderRightColor { get; set; }
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    [SchemaIndex(29)]
    public IntegerValue DiagramLayout { get; set; }
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    [SchemaIndex(30)]
    public IntegerValue DiagramNodeKind { get; set; }
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    [SchemaIndex(31)]
    public IntegerValue DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    [SchemaIndex(32)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode { get; set; }
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    [SchemaIndex(33)]
    public TrueFalseValue Filled { get; set; }
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    [SchemaIndex(34)]
    public StringValue FillColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    [SchemaIndex(35)]
    public TrueFalseValue Stroked { get; set; }
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    [SchemaIndex(36)]
    public StringValue StrokeColor { get; set; }
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    [SchemaIndex(37)]
    public StringValue StrokeWeight { get; set; }
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    [SchemaIndex(38)]
    public TrueFalseValue InsetPen { get; set; }
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    [SchemaIndex(39)]
    public Int32Value OptionalNumber { get; set; }
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    [SchemaIndex(40)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType { get; set; }
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    [SchemaIndex(41)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    [SchemaIndex(42)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    [SchemaIndex(43)]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    [SchemaIndex(44)]
    public TrueFalseValue ForceDash { get; set; }
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    [SchemaIndex(45)]
    public TrueFalseValue OleIcon { get; set; }
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    [SchemaIndex(46)]
    public TrueFalseBlankValue Ole { get; set; }
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    [SchemaIndex(47)]
    public TrueFalseValue PreferRelative { get; set; }
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    [SchemaIndex(48)]
    public TrueFalseValue ClipToWrap { get; set; }
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    [SchemaIndex(49)]
    public TrueFalseValue Clip { get; set; }
    /// <summary>
    /// <para> Rounded Corner Arc Size.</para>
    /// <para>Represents the following attribute in the schema: arcsize </para>
    /// </summary>
    [SchemaAttr(0, "arcsize")]
    [SchemaIndex(50)]
    public StringValue ArcSize { get; set; }

    /// <summary>
    /// Initializes a new instance of the RoundRectangle class.
    /// </summary>
    public RoundRectangle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RoundRectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RoundRectangle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RoundRectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RoundRectangle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RoundRectangle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RoundRectangle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundRectangle>(deep);

}
/// <summary>
/// <para>Shape Handle.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:h.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeHandle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12598;
    /// <inheritdoc/>
    public override string LocalName => "h";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Handle Position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    [SchemaIndex(0)]
    public StringValue Position { get; set; }
    /// <summary>
    /// <para> Handle Polar Center.</para>
    /// <para>Represents the following attribute in the schema: polar </para>
    /// </summary>
    [SchemaAttr(0, "polar")]
    [SchemaIndex(1)]
    public StringValue Polar { get; set; }
    /// <summary>
    /// <para> Handle Coordinate Mapping.</para>
    /// <para>Represents the following attribute in the schema: map </para>
    /// </summary>
    [SchemaAttr(0, "map")]
    [SchemaIndex(2)]
    public StringValue Map { get; set; }
    /// <summary>
    /// <para> Invert Handle's X Position.</para>
    /// <para>Represents the following attribute in the schema: invx </para>
    /// </summary>
    [SchemaAttr(0, "invx")]
    [SchemaIndex(3)]
    public TrueFalseBlankValue InvertX { get; set; }
    /// <summary>
    /// <para> Invert Handle's Y Position.</para>
    /// <para>Represents the following attribute in the schema: invy </para>
    /// </summary>
    [SchemaAttr(0, "invy")]
    [SchemaIndex(4)]
    public TrueFalseBlankValue InvertY { get; set; }
    /// <summary>
    /// <para> Handle Inversion Toggle.</para>
    /// <para>Represents the following attribute in the schema: switch </para>
    /// </summary>
    [SchemaAttr(0, "switch")]
    [SchemaIndex(5)]
    public TrueFalseBlankValue Switch { get; set; }
    /// <summary>
    /// <para> Handle X Position Range.</para>
    /// <para>Represents the following attribute in the schema: xrange </para>
    /// </summary>
    [SchemaAttr(0, "xrange")]
    [SchemaIndex(6)]
    public StringValue XRange { get; set; }
    /// <summary>
    /// <para> Handle Y Position Range.</para>
    /// <para>Represents the following attribute in the schema: yrange </para>
    /// </summary>
    [SchemaAttr(0, "yrange")]
    [SchemaIndex(7)]
    public StringValue YRange { get; set; }
    /// <summary>
    /// <para> Handle Polar Radius Range.</para>
    /// <para>Represents the following attribute in the schema: radiusrange </para>
    /// </summary>
    [SchemaAttr(0, "radiusrange")]
    [SchemaIndex(8)]
    public StringValue RadiusRange { get; set; }

    /// <summary>
    /// Initializes a new instance of the ShapeHandle class.
    /// </summary>
    public ShapeHandle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandle>(deep);

}
/// <summary>
/// <para>Single Formula.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:f.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Formula : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12599;
    /// <inheritdoc/>
    public override string LocalName => "f";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Equation.</para>
    /// <para>Represents the following attribute in the schema: eqn </para>
    /// </summary>
    [SchemaAttr(0, "eqn")]
    [SchemaIndex(0)]
    public StringValue Equation { get; set; }

    /// <summary>
    /// Initializes a new instance of the Formula class.
    /// </summary>
    public Formula():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);

}
/// <summary>
/// VML Extension Handling Behaviors 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtensionHandlingBehaviorValues
{  
	///<summary>
///Not renderable.
///<para>When the item is serialized out as xml, its value is "view".</para>
///</summary>
[EnumString("view")]
View,
///<summary>
///Editable.
///<para>When the item is serialized out as xml, its value is "edit".</para>
///</summary>
[EnumString("edit")]
Edit,
///<summary>
///Renderable.
///<para>When the item is serialized out as xml, its value is "backwardCompatible".</para>
///</summary>
[EnumString("backwardCompatible")]
BackwardCompatible,
 
}
/// <summary>
/// Shape Fill Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FillTypeValues
{  
	///<summary>
///Solid Fill.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///Linear Gradient.
///<para>When the item is serialized out as xml, its value is "gradient".</para>
///</summary>
[EnumString("gradient")]
Gradient,
///<summary>
///Radial Gradient.
///<para>When the item is serialized out as xml, its value is "gradientRadial".</para>
///</summary>
[EnumString("gradientRadial")]
GradientRadial,
///<summary>
///Tiled Image.
///<para>When the item is serialized out as xml, its value is "tile".</para>
///</summary>
[EnumString("tile")]
Tile,
///<summary>
///Image Pattern.
///<para>When the item is serialized out as xml, its value is "pattern".</para>
///</summary>
[EnumString("pattern")]
Pattern,
///<summary>
///Stretch Image to Fit.
///<para>When the item is serialized out as xml, its value is "frame".</para>
///</summary>
[EnumString("frame")]
Frame,
 
}
/// <summary>
/// Gradient Fill Computation Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FillMethodValues
{  
	///<summary>
///No Gradient Fill.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Linear Fill.
///<para>When the item is serialized out as xml, its value is "linear".</para>
///</summary>
[EnumString("linear")]
Linear,
///<summary>
///Sigma Fill.
///<para>When the item is serialized out as xml, its value is "sigma".</para>
///</summary>
[EnumString("sigma")]
Sigma,
///<summary>
///Application Default Fill.
///<para>When the item is serialized out as xml, its value is "any".</para>
///</summary>
[EnumString("any")]
Any,
///<summary>
///Linear Sigma Fill.
///<para>When the item is serialized out as xml, its value is "linear sigma".</para>
///</summary>
[EnumString("linear sigma")]
Linearsigma,
 
}
/// <summary>
/// Stroke Line Style 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeLineStyleValues
{  
	///<summary>
///Single Line.
///<para>When the item is serialized out as xml, its value is "single".</para>
///</summary>
[EnumString("single")]
Single,
///<summary>
///Two Thin Lines.
///<para>When the item is serialized out as xml, its value is "thinThin".</para>
///</summary>
[EnumString("thinThin")]
ThinThin,
///<summary>
///Thin Line Outside Thick Line.
///<para>When the item is serialized out as xml, its value is "thinThick".</para>
///</summary>
[EnumString("thinThick")]
ThinThick,
///<summary>
///Thick Line Outside Thin Line.
///<para>When the item is serialized out as xml, its value is "thickThin".</para>
///</summary>
[EnumString("thickThin")]
ThickThin,
///<summary>
///Thck Line Between Thin Lines.
///<para>When the item is serialized out as xml, its value is "thickBetweenThin".</para>
///</summary>
[EnumString("thickBetweenThin")]
ThickBetweenThin,
 
}
/// <summary>
/// Line Join Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeJoinStyleValues
{  
	///<summary>
///Round Joint.
///<para>When the item is serialized out as xml, its value is "round".</para>
///</summary>
[EnumString("round")]
Round,
///<summary>
///Bevel Joint.
///<para>When the item is serialized out as xml, its value is "bevel".</para>
///</summary>
[EnumString("bevel")]
Bevel,
///<summary>
///Miter Joint.
///<para>When the item is serialized out as xml, its value is "miter".</para>
///</summary>
[EnumString("miter")]
Miter,
 
}
/// <summary>
/// Stroke End Cap Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeEndCapValues
{  
	///<summary>
///Flat End.
///<para>When the item is serialized out as xml, its value is "flat".</para>
///</summary>
[EnumString("flat")]
Flat,
///<summary>
///Square End.
///<para>When the item is serialized out as xml, its value is "square".</para>
///</summary>
[EnumString("square")]
Square,
///<summary>
///Round End.
///<para>When the item is serialized out as xml, its value is "round".</para>
///</summary>
[EnumString("round")]
Round,
 
}
/// <summary>
/// Stroke Arrowhead Length 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeArrowLengthValues
{  
	///<summary>
///Short Arrowhead.
///<para>When the item is serialized out as xml, its value is "short".</para>
///</summary>
[EnumString("short")]
Short,
///<summary>
///Medium Arrowhead.
///<para>When the item is serialized out as xml, its value is "medium".</para>
///</summary>
[EnumString("medium")]
Medium,
///<summary>
///Long Arrowhead.
///<para>When the item is serialized out as xml, its value is "long".</para>
///</summary>
[EnumString("long")]
Long,
 
}
/// <summary>
/// Stroke Arrowhead Width 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeArrowWidthValues
{  
	///<summary>
///Narrow Arrowhead.
///<para>When the item is serialized out as xml, its value is "narrow".</para>
///</summary>
[EnumString("narrow")]
Narrow,
///<summary>
///Medium Arrowhead.
///<para>When the item is serialized out as xml, its value is "medium".</para>
///</summary>
[EnumString("medium")]
Medium,
///<summary>
///Wide Arrowhead.
///<para>When the item is serialized out as xml, its value is "wide".</para>
///</summary>
[EnumString("wide")]
Wide,
 
}
/// <summary>
/// Stroke Arrowhead Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeArrowValues
{  
	///<summary>
///No Arrowhead.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Block Arrowhead.
///<para>When the item is serialized out as xml, its value is "block".</para>
///</summary>
[EnumString("block")]
Block,
///<summary>
///Classic Arrowhead.
///<para>When the item is serialized out as xml, its value is "classic".</para>
///</summary>
[EnumString("classic")]
Classic,
///<summary>
///Oval Arrowhead.
///<para>When the item is serialized out as xml, its value is "oval".</para>
///</summary>
[EnumString("oval")]
Oval,
///<summary>
///Diamond Arrowhead.
///<para>When the item is serialized out as xml, its value is "diamond".</para>
///</summary>
[EnumString("diamond")]
Diamond,
///<summary>
///Open Arrowhead.
///<para>When the item is serialized out as xml, its value is "open".</para>
///</summary>
[EnumString("open")]
Open,
 
}
/// <summary>
/// Image Scaling Behavior 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ImageAspectValues
{  
	///<summary>
///Ignore Aspect Ratio.
///<para>When the item is serialized out as xml, its value is "ignore".</para>
///</summary>
[EnumString("ignore")]
Ignore,
///<summary>
///At Most.
///<para>When the item is serialized out as xml, its value is "atMost".</para>
///</summary>
[EnumString("atMost")]
AtMost,
///<summary>
///At Least.
///<para>When the item is serialized out as xml, its value is "atLeast".</para>
///</summary>
[EnumString("atLeast")]
AtLeast,
 
}
/// <summary>
/// Shape Grouping Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum EditAsValues
{  
	///<summary>
///Shape Canvas.
///<para>When the item is serialized out as xml, its value is "canvas".</para>
///</summary>
[EnumString("canvas")]
Canvas,
///<summary>
///Organization Chart Diagram.
///<para>When the item is serialized out as xml, its value is "orgchart".</para>
///</summary>
[EnumString("orgchart")]
OrganizationChart,
///<summary>
///Radial Diagram.
///<para>When the item is serialized out as xml, its value is "radial".</para>
///</summary>
[EnumString("radial")]
Radial,
///<summary>
///Cycle Diagram.
///<para>When the item is serialized out as xml, its value is "cycle".</para>
///</summary>
[EnumString("cycle")]
Cycle,
///<summary>
///Pyramid Diagram.
///<para>When the item is serialized out as xml, its value is "stacked".</para>
///</summary>
[EnumString("stacked")]
Stacked,
///<summary>
///Venn Diagram.
///<para>When the item is serialized out as xml, its value is "venn".</para>
///</summary>
[EnumString("venn")]
Venn,
///<summary>
///Bullseye Diagram.
///<para>When the item is serialized out as xml, its value is "bullseye".</para>
///</summary>
[EnumString("bullseye")]
Bullseye,
 
}
/// <summary>
/// Shadow Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ShadowValues
{  
	///<summary>
///Single Shadow.
///<para>When the item is serialized out as xml, its value is "single".</para>
///</summary>
[EnumString("single")]
Single,
///<summary>
///Double Shadow.
///<para>When the item is serialized out as xml, its value is "double".</para>
///</summary>
[EnumString("double")]
Double,
///<summary>
///Embossed Shadow.
///<para>When the item is serialized out as xml, its value is "emboss".</para>
///</summary>
[EnumString("emboss")]
Emboss,
///<summary>
///Perspective Shadow.
///<para>When the item is serialized out as xml, its value is "perspective".</para>
///</summary>
[EnumString("perspective")]
Perspective,
///<summary>
///shapeRelative.
///<para>When the item is serialized out as xml, its value is "shapeRelative".</para>
///</summary>
[EnumString("shapeRelative")]
ShapeRelative,
///<summary>
///drawingRelative.
///<para>When the item is serialized out as xml, its value is "drawingRelative".</para>
///</summary>
[EnumString("drawingRelative")]
DrawingRelative,
 
}
/// <summary>
/// Defines the StrokeFillTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeFillTypeValues
{  
	///<summary>
///solid.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///tile.
///<para>When the item is serialized out as xml, its value is "tile".</para>
///</summary>
[EnumString("tile")]
Tile,
///<summary>
///pattern.
///<para>When the item is serialized out as xml, its value is "pattern".</para>
///</summary>
[EnumString("pattern")]
Pattern,
///<summary>
///frame.
///<para>When the item is serialized out as xml, its value is "frame".</para>
///</summary>
[EnumString("frame")]
Frame,
 
}
}
 
 
