//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

using SteamKit2.GC.Internal;
   
// Generated from: dota_commonmessages.proto
// Note: requires additional types generated from: networkbasetypes.proto
namespace Dota2.GC.Dota.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_LocationPing")]
  public partial class CDOTAMsg_LocationPing : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_LocationPing() {}
    

    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }

    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }

    private int _target = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"target", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int target
    {
      get { return _target; }
      set { _target = value; }
    }

    private bool _direct_ping = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"direct_ping", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool direct_ping
    {
      get { return _direct_ping; }
      set { _direct_ping = value; }
    }

    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_ItemAlert")]
  public partial class CDOTAMsg_ItemAlert : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_ItemAlert() {}
    

    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }

    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }

    private int _itemid = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_MapLine")]
  public partial class CDOTAMsg_MapLine : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_MapLine() {}
    

    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }

    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }

    private bool _initial = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"initial", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool initial
    {
      get { return _initial; }
      set { _initial = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_WorldLine")]
  public partial class CDOTAMsg_WorldLine : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_WorldLine() {}
    

    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }

    private int _y = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }

    private int _z = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int z
    {
      get { return _z; }
      set { _z = value; }
    }

    private bool _initial = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"initial", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool initial
    {
      get { return _initial; }
      set { _initial = value; }
    }

    private bool _end = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"end", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool end
    {
      get { return _end; }
      set { _end = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_SendStatPopup")]
  public partial class CDOTAMsg_SendStatPopup : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_SendStatPopup() {}
    

    private EDOTAStatPopupTypes _style = EDOTAStatPopupTypes.k_EDOTA_SPT_Textline;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"style", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(EDOTAStatPopupTypes.k_EDOTA_SPT_Textline)]
    public EDOTAStatPopupTypes style
    {
      get { return _style; }
      set { _style = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _stat_strings = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"stat_strings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> stat_strings
    {
      get { return _stat_strings; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _stat_images = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"stat_images", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> stat_images
    {
      get { return _stat_images; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_CoachHUDPing")]
  public partial class CDOTAMsg_CoachHUDPing : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_CoachHUDPing() {}
    

    private uint _x = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint x
    {
      get { return _x; }
      set { _x = value; }
    }

    private uint _y = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint y
    {
      get { return _y; }
      set { _y = value; }
    }

    private string _tgtpath = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tgtpath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tgtpath
    {
      get { return _tgtpath; }
      set { _tgtpath = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDOTAMsg_UnitOrder")]
  public partial class CDOTAMsg_UnitOrder : global::ProtoBuf.IExtensible
  {
    public CDOTAMsg_UnitOrder() {}
    

    private int _issuer = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"issuer", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int issuer
    {
      get { return _issuer; }
      set { _issuer = value; }
    }

    private dotaunitorder_t _order_type = dotaunitorder_t.DOTA_UNIT_ORDER_NONE;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"order_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(dotaunitorder_t.DOTA_UNIT_ORDER_NONE)]
    public dotaunitorder_t order_type
    {
      get { return _order_type; }
      set { _order_type = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _units = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"units", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> units
    {
      get { return _units; }
    }
  

    private int _target_index = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"target_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int target_index
    {
      get { return _target_index; }
      set { _target_index = value; }
    }

    private int _ability_index = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ability_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ability_index
    {
      get { return _ability_index; }
      set { _ability_index = value; }
    }

    private CMsgVector _position = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgVector position
    {
      get { return _position; }
      set { _position = value; }
    }

    private bool _queue = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"queue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool queue
    {
      get { return _queue; }
      set { _queue = value; }
    }

    private int _sequence_number = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"sequence_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sequence_number
    {
      get { return _sequence_number; }
      set { _sequence_number = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDOTAChatWheelMessage", EnumPassthru=true)]
    public enum EDOTAChatWheelMessage
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Ok", Value=0)]
      k_EDOTA_CW_Ok = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Care", Value=1)]
      k_EDOTA_CW_Care = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GetBack", Value=2)]
      k_EDOTA_CW_GetBack = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_NeedWards", Value=3)]
      k_EDOTA_CW_NeedWards = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Stun", Value=4)]
      k_EDOTA_CW_Stun = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Help", Value=5)]
      k_EDOTA_CW_Help = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Push", Value=6)]
      k_EDOTA_CW_Push = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GoodJob", Value=7)]
      k_EDOTA_CW_GoodJob = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing", Value=8)]
      k_EDOTA_CW_Missing = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing_Top", Value=9)]
      k_EDOTA_CW_Missing_Top = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing_Mid", Value=10)]
      k_EDOTA_CW_Missing_Mid = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Missing_Bottom", Value=11)]
      k_EDOTA_CW_Missing_Bottom = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Go", Value=12)]
      k_EDOTA_CW_Go = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Initiate", Value=13)]
      k_EDOTA_CW_Initiate = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Follow", Value=14)]
      k_EDOTA_CW_Follow = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Group_Up", Value=15)]
      k_EDOTA_CW_Group_Up = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Spread_Out", Value=16)]
      k_EDOTA_CW_Spread_Out = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Split_Farm", Value=17)]
      k_EDOTA_CW_Split_Farm = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Attack", Value=18)]
      k_EDOTA_CW_Attack = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_BRB", Value=19)]
      k_EDOTA_CW_BRB = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Dive", Value=20)]
      k_EDOTA_CW_Dive = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_OMW", Value=21)]
      k_EDOTA_CW_OMW = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Get_Ready", Value=22)]
      k_EDOTA_CW_Get_Ready = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Bait", Value=23)]
      k_EDOTA_CW_Bait = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Heal", Value=24)]
      k_EDOTA_CW_Heal = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Mana", Value=25)]
      k_EDOTA_CW_Mana = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_OOM", Value=26)]
      k_EDOTA_CW_OOM = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Skill_Cooldown", Value=27)]
      k_EDOTA_CW_Skill_Cooldown = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Ulti_Ready", Value=28)]
      k_EDOTA_CW_Ulti_Ready = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Enemy_Returned", Value=29)]
      k_EDOTA_CW_Enemy_Returned = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_All_Missing", Value=30)]
      k_EDOTA_CW_All_Missing = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Enemy_Incoming", Value=31)]
      k_EDOTA_CW_Enemy_Incoming = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Invis_Enemy", Value=32)]
      k_EDOTA_CW_Invis_Enemy = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Enemy_Had_Rune", Value=33)]
      k_EDOTA_CW_Enemy_Had_Rune = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Split_Push", Value=34)]
      k_EDOTA_CW_Split_Push = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Coming_To_Gank", Value=35)]
      k_EDOTA_CW_Coming_To_Gank = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Request_Gank", Value=36)]
      k_EDOTA_CW_Request_Gank = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Fight_Under_Tower", Value=37)]
      k_EDOTA_CW_Fight_Under_Tower = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Deny_Tower", Value=38)]
      k_EDOTA_CW_Deny_Tower = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Buy_Courier", Value=39)]
      k_EDOTA_CW_Buy_Courier = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Upgrade_Courier", Value=40)]
      k_EDOTA_CW_Upgrade_Courier = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Need_Detection", Value=41)]
      k_EDOTA_CW_Need_Detection = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_They_Have_Detection", Value=42)]
      k_EDOTA_CW_They_Have_Detection = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Buy_TP", Value=43)]
      k_EDOTA_CW_Buy_TP = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Reuse_Courier", Value=44)]
      k_EDOTA_CW_Reuse_Courier = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Deward", Value=45)]
      k_EDOTA_CW_Deward = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Building_Mek", Value=46)]
      k_EDOTA_CW_Building_Mek = 46,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Building_Pipe", Value=47)]
      k_EDOTA_CW_Building_Pipe = 47,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Stack_And_Pull", Value=48)]
      k_EDOTA_CW_Stack_And_Pull = 48,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Pull", Value=49)]
      k_EDOTA_CW_Pull = 49,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Pulling", Value=50)]
      k_EDOTA_CW_Pulling = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Stack", Value=51)]
      k_EDOTA_CW_Stack = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Jungling", Value=52)]
      k_EDOTA_CW_Jungling = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Roshan", Value=53)]
      k_EDOTA_CW_Roshan = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Affirmative", Value=54)]
      k_EDOTA_CW_Affirmative = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Wait", Value=55)]
      k_EDOTA_CW_Wait = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Pause", Value=56)]
      k_EDOTA_CW_Pause = 56,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Current_Time", Value=57)]
      k_EDOTA_CW_Current_Time = 57,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Check_Runes", Value=58)]
      k_EDOTA_CW_Check_Runes = 58,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Smoke_Gank", Value=59)]
      k_EDOTA_CW_Smoke_Gank = 59,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GLHF", Value=60)]
      k_EDOTA_CW_GLHF = 60,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Nice", Value=61)]
      k_EDOTA_CW_Nice = 61,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Thanks", Value=62)]
      k_EDOTA_CW_Thanks = 62,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Sorry", Value=63)]
      k_EDOTA_CW_Sorry = 63,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_No_Give_Up", Value=64)]
      k_EDOTA_CW_No_Give_Up = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Just_Happened", Value=65)]
      k_EDOTA_CW_Just_Happened = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Game_Is_Hard", Value=66)]
      k_EDOTA_CW_Game_Is_Hard = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_New_Meta", Value=67)]
      k_EDOTA_CW_New_Meta = 67,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_My_Bad", Value=68)]
      k_EDOTA_CW_My_Bad = 68,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Regret", Value=69)]
      k_EDOTA_CW_Regret = 69,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Relax", Value=70)]
      k_EDOTA_CW_Relax = 70,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_MissingHero", Value=71)]
      k_EDOTA_CW_MissingHero = 71,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_ReturnedHero", Value=72)]
      k_EDOTA_CW_ReturnedHero = 72,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GG", Value=73)]
      k_EDOTA_CW_GG = 73,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_GGWP", Value=74)]
      k_EDOTA_CW_GGWP = 74,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_All_GG", Value=75)]
      k_EDOTA_CW_All_GG = 75,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_All_GGWP", Value=76)]
      k_EDOTA_CW_All_GGWP = 76,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_What_To_Buy", Value=77)]
      k_EDOTA_CW_What_To_Buy = 77,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Im_Retreating", Value=78)]
      k_EDOTA_CW_Im_Retreating = 78,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Space_Created", Value=79)]
      k_EDOTA_CW_Space_Created = 79,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Whoops", Value=80)]
      k_EDOTA_CW_Whoops = 80,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Tower_then_Back", Value=81)]
      k_EDOTA_CW_Tower_then_Back = 81,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Barracks_then_Back", Value=82)]
      k_EDOTA_CW_Barracks_then_Back = 82,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Ward_Bottom_Rune", Value=83)]
      k_EDOTA_CW_Ward_Bottom_Rune = 83,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Ward_Top_Rune", Value=84)]
      k_EDOTA_CW_Ward_Top_Rune = 84,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_CW_Zeus_Ult", Value=85)]
      k_EDOTA_CW_Zeus_Ult = 85
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EDOTAStatPopupTypes", EnumPassthru=true)]
    public enum EDOTAStatPopupTypes
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_SPT_Textline", Value=0)]
      k_EDOTA_SPT_Textline = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_SPT_Basic", Value=1)]
      k_EDOTA_SPT_Basic = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_SPT_Poll", Value=2)]
      k_EDOTA_SPT_Poll = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EDOTA_SPT_Grid", Value=3)]
      k_EDOTA_SPT_Grid = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"dotaunitorder_t", EnumPassthru=true)]
    public enum dotaunitorder_t
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_NONE", Value=0)]
      DOTA_UNIT_ORDER_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_MOVE_TO_POSITION", Value=1)]
      DOTA_UNIT_ORDER_MOVE_TO_POSITION = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_MOVE_TO_TARGET", Value=2)]
      DOTA_UNIT_ORDER_MOVE_TO_TARGET = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_ATTACK_MOVE", Value=3)]
      DOTA_UNIT_ORDER_ATTACK_MOVE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_ATTACK_TARGET", Value=4)]
      DOTA_UNIT_ORDER_ATTACK_TARGET = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_CAST_POSITION", Value=5)]
      DOTA_UNIT_ORDER_CAST_POSITION = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_CAST_TARGET", Value=6)]
      DOTA_UNIT_ORDER_CAST_TARGET = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_CAST_TARGET_TREE", Value=7)]
      DOTA_UNIT_ORDER_CAST_TARGET_TREE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_CAST_NO_TARGET", Value=8)]
      DOTA_UNIT_ORDER_CAST_NO_TARGET = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_CAST_TOGGLE", Value=9)]
      DOTA_UNIT_ORDER_CAST_TOGGLE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_HOLD_POSITION", Value=10)]
      DOTA_UNIT_ORDER_HOLD_POSITION = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_TRAIN_ABILITY", Value=11)]
      DOTA_UNIT_ORDER_TRAIN_ABILITY = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_DROP_ITEM", Value=12)]
      DOTA_UNIT_ORDER_DROP_ITEM = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_GIVE_ITEM", Value=13)]
      DOTA_UNIT_ORDER_GIVE_ITEM = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_PICKUP_ITEM", Value=14)]
      DOTA_UNIT_ORDER_PICKUP_ITEM = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_PICKUP_RUNE", Value=15)]
      DOTA_UNIT_ORDER_PICKUP_RUNE = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_PURCHASE_ITEM", Value=16)]
      DOTA_UNIT_ORDER_PURCHASE_ITEM = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_SELL_ITEM", Value=17)]
      DOTA_UNIT_ORDER_SELL_ITEM = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_DISASSEMBLE_ITEM", Value=18)]
      DOTA_UNIT_ORDER_DISASSEMBLE_ITEM = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_MOVE_ITEM", Value=19)]
      DOTA_UNIT_ORDER_MOVE_ITEM = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_CAST_TOGGLE_AUTO", Value=20)]
      DOTA_UNIT_ORDER_CAST_TOGGLE_AUTO = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_STOP", Value=21)]
      DOTA_UNIT_ORDER_STOP = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_TAUNT", Value=22)]
      DOTA_UNIT_ORDER_TAUNT = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_BUYBACK", Value=23)]
      DOTA_UNIT_ORDER_BUYBACK = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_GLYPH", Value=24)]
      DOTA_UNIT_ORDER_GLYPH = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_EJECT_ITEM_FROM_STASH", Value=25)]
      DOTA_UNIT_ORDER_EJECT_ITEM_FROM_STASH = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_CAST_RUNE", Value=26)]
      DOTA_UNIT_ORDER_CAST_RUNE = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_PING_ABILITY", Value=27)]
      DOTA_UNIT_ORDER_PING_ABILITY = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_MOVE_TO_DIRECTION", Value=28)]
      DOTA_UNIT_ORDER_MOVE_TO_DIRECTION = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_PATROL", Value=29)]
      DOTA_UNIT_ORDER_PATROL = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_UNIT_ORDER_VECTOR_TARGET_POSITION", Value=30)]
      DOTA_UNIT_ORDER_VECTOR_TARGET_POSITION = 30
    }
  
}
#pragma warning restore 1591
