
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public final class DemoExplicitType extends AbstractBean {
    public DemoExplicitType(JsonObject _buf) { 
        x1 = _buf.get("x1").getAsByte();
        x2 = _buf.get("x2").getAsShort();
        x3 = _buf.get("x3").getAsInt();
        x4 = _buf.get("x4").getAsLong();
        x5 = _buf.get("x5").getAsFloat();
        x6 = _buf.get("x6").getAsDouble();
        x7 = _buf.get("x7").getAsLong();
    }

    public static DemoExplicitType deserialize(JsonObject _buf) {
            return new cfg.test.DemoExplicitType(_buf);
    }

    public final byte x1;
    public final short x2;
    public final int x3;
    public final long x4;
    public final float x5;
    public final double x6;
    public final long x7;

    public static final int __ID__ = 370351885;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "x5:" + x5 + ","
        + "x6:" + x6 + ","
        + "x7:" + x7 + ","
        + "}";
    }
}
