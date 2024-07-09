
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.ai
{

public sealed partial class MoveToRandomLocation : ai.Task
{
    public MoveToRandomLocation(JToken _buf)  : base(_buf) 
    {
        JObject _obj = _buf as JObject;
        OriginPositionKey = (string)_obj.GetValue("origin_position_key");
        Radius = (float)_obj.GetValue("radius");
    }

    public static MoveToRandomLocation DeserializeMoveToRandomLocation(JToken _buf)
    {
        return new ai.MoveToRandomLocation(_buf);
    }

    public readonly string OriginPositionKey;
    public readonly float Radius;


    public const int __ID__ = -2140042998;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(Decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(Services) + ","
        + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
        + "originPositionKey:" + OriginPositionKey + ","
        + "radius:" + Radius + ","
        + "}";
    }
}
}
