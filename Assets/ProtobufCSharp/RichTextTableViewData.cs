//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RichTextTableViewData.proto
namespace ProtoBufFile
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BackGroundData")]
  public partial class BackGroundData : global::ProtoBuf.IExtensible
  {
    public BackGroundData() {}
    
    private string _buttomBarKey = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"buttomBarKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buttomBarKey
    {
      get { return _buttomBarKey; }
      set { _buttomBarKey = value; }
    }
    private string _gameElementkey = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gameElementkey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gameElementkey
    {
      get { return _gameElementkey; }
      set { _gameElementkey = value; }
    }
    private string _particleKey = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"particleKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string particleKey
    {
      get { return _particleKey; }
      set { _particleKey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CellData")]
  public partial class CellData : global::ProtoBuf.IExtensible
  {
    public CellData() {}
    
    private string _content;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private string _modelCureKey = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"modelCureKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string modelCureKey
    {
      get { return _modelCureKey; }
      set { _modelCureKey = value; }
    }
    private string _modelImageKey = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"modelImageKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string modelImageKey
    {
      get { return _modelImageKey; }
      set { _modelImageKey = value; }
    }
    private string _particlesKey = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"particlesKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string particlesKey
    {
      get { return _particlesKey; }
      set { _particlesKey = value; }
    }
    private TableViewCellAnimationType _animationType = TableViewCellAnimationType.None;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"animationType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(TableViewCellAnimationType.None)]
    public TableViewCellAnimationType animationType
    {
      get { return _animationType; }
      set { _animationType = value; }
    }
    private float _charPrintDelay = (float)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"charPrintDelay", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float charPrintDelay
    {
      get { return _charPrintDelay; }
      set { _charPrintDelay = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RichTextTableViewData")]
  public partial class RichTextTableViewData : global::ProtoBuf.IExtensible
  {
    public RichTextTableViewData() {}
    
    private string _code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private CellData _cellData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cellData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CellData cellData
    {
      get { return _cellData; }
      set { _cellData = value; }
    }
    private BackGroundData _backGroudData = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"backGroudData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BackGroundData backGroudData
    {
      get { return _backGroudData; }
      set { _backGroudData = value; }
    }
    private readonly global::System.Collections.Generic.List<LinkObject> _linkGroups = new global::System.Collections.Generic.List<LinkObject>();
    [global::ProtoBuf.ProtoMember(4, Name=@"linkGroups", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<LinkObject> linkGroups
    {
      get { return _linkGroups; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClickLink")]
  public partial class ClickLink : global::ProtoBuf.IExtensible
  {
    public ClickLink() {}
    
    private string _code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private string _linkId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"linkId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string linkId
    {
      get { return _linkId; }
      set { _linkId = value; }
    }
    private readonly global::System.Collections.Generic.List<LinkObject> _linkGroups = new global::System.Collections.Generic.List<LinkObject>();
    [global::ProtoBuf.ProtoMember(3, Name=@"linkGroups", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<LinkObject> linkGroups
    {
      get { return _linkGroups; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LinkObject")]
  public partial class LinkObject : global::ProtoBuf.IExtensible
  {
    public LinkObject() {}
    
    private string _linkId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"linkId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string linkId
    {
      get { return _linkId; }
      set { _linkId = value; }
    }
    private string _linkName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"linkName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string linkName
    {
      get { return _linkName; }
      set { _linkName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParamType")]
  public partial class ParamType : global::ProtoBuf.IExtensible
  {
    public ParamType() {}
    
    private float _delay;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"delay", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float delay
    {
      get { return _delay; }
      set { _delay = value; }
    }
    private string _funName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"funName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string funName
    {
      get { return _funName; }
      set { _funName = value; }
    }
    private readonly global::System.Collections.Generic.List<ParamGameObject> _objectList = new global::System.Collections.Generic.List<ParamGameObject>();
    [global::ProtoBuf.ProtoMember(3, Name=@"objectList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ParamGameObject> objectList
    {
      get { return _objectList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParamGameObject")]
  public partial class ParamGameObject : global::ProtoBuf.IExtensible
  {
    public ParamGameObject() {}
    
    private string _objKey;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"objKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string objKey
    {
      get { return _objKey; }
      set { _objKey = value; }
    }
    private string _objValueType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"objValueType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string objValueType
    {
      get { return _objValueType; }
      set { _objValueType = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _objValue = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"objValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> objValue
    {
      get { return _objValue; }
    }
  
    private readonly global::System.Collections.Generic.List<SearchCondition> _searchList = new global::System.Collections.Generic.List<SearchCondition>();
    [global::ProtoBuf.ProtoMember(4, Name=@"searchList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SearchCondition> searchList
    {
      get { return _searchList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchCondition")]
  public partial class SearchCondition : global::ProtoBuf.IExtensible
  {
    public SearchCondition() {}
    
    private string _formula;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"formula", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string formula
    {
      get { return _formula; }
      set { _formula = value; }
    }
    private readonly global::System.Collections.Generic.List<SearchParameter> _searchParameterList = new global::System.Collections.Generic.List<SearchParameter>();
    [global::ProtoBuf.ProtoMember(2, Name=@"searchParameterList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SearchParameter> searchParameterList
    {
      get { return _searchParameterList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchParameter")]
  public partial class SearchParameter : global::ProtoBuf.IExtensible
  {
    public SearchParameter() {}
    
    private string _paramKey;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"paramKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string paramKey
    {
      get { return _paramKey; }
      set { _paramKey = value; }
    }
    private string _paramValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"paramValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string paramValue
    {
      get { return _paramValue; }
      set { _paramValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParamGameObjectResult")]
  public partial class ParamGameObjectResult : global::ProtoBuf.IExtensible
  {
    public ParamGameObjectResult() {}
    
    private readonly global::System.Collections.Generic.List<ParamObjectResult> _paramResult = new global::System.Collections.Generic.List<ParamObjectResult>();
    [global::ProtoBuf.ProtoMember(1, Name=@"paramResult", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ParamObjectResult> paramResult
    {
      get { return _paramResult; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParamObjectResult")]
  public partial class ParamObjectResult : global::ProtoBuf.IExtensible
  {
    public ParamObjectResult() {}
    
    private string _objKey;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"objKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string objKey
    {
      get { return _objKey; }
      set { _objKey = value; }
    }
    private readonly global::System.Collections.Generic.List<LinkObject> _linkGroups = new global::System.Collections.Generic.List<LinkObject>();
    [global::ProtoBuf.ProtoMember(2, Name=@"linkGroups", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<LinkObject> linkGroups
    {
      get { return _linkGroups; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"TableViewCellAnimationType")]
    public enum TableViewCellAnimationType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"None", Value=0)]
      None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Alert", Value=1)]
      Alert = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VerticalExpand", Value=2)]
      VerticalExpand = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Bang", Value=3)]
      Bang = 3
    }
  
}