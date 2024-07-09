
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.test
{

public sealed partial class TestNull : Luban.BeanBase
{
    public TestNull(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Id = (int)_obj.GetValue("id");
        {if (_obj.TryGetValue("x1", out var _j)) { X1 = (int)_j; } else { X1 = null; } }
        {if (_obj.TryGetValue("x2", out var _j)) { X2 = (test.DemoEnum?)(int)_j; } else { X2 = null; } }
        {if (_obj.TryGetValue("x3", out var _j)) { X3 = test.DemoType1.DeserializeDemoType1(_j); } else { X3 = null; } }
        {if (_obj.TryGetValue("x4", out var _j)) { X4 = test.DemoDynamic.DeserializeDemoDynamic(_j); } else { X4 = null; } }
        {if (_obj.TryGetValue("s1", out var _j)) { S1 = (string)_j; } else { S1 = null; } }
        {if (_obj.TryGetValue("s2", out var _j)) { S2 = (string)_j; } else { S2 = null; } }
    }

    public static TestNull DeserializeTestNull(JToken _buf)
    {
        return new test.TestNull(_buf);
    }

    public readonly int Id;
    public readonly int? X1;
    public readonly test.DemoEnum? X2;
    public readonly test.DemoType1 X3;
    public readonly test.DemoDynamic X4;
    public readonly string S1;
    public readonly string S2;


    public const int __ID__ = 339868469;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        X3?.ResolveRef(tables);
        X4?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x1:" + X1 + ","
        + "x2:" + X2 + ","
        + "x3:" + X3 + ","
        + "x4:" + X4 + ","
        + "s1:" + S1 + ","
        + "s2:" + S2 + ","
        + "}";
    }
}
}
