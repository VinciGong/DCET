﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Google_Protobuf_WireFormat_WireTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(Google.Protobuf.WireFormat.WireType));
		L.RegConstant("Varint", Google.Protobuf.WireFormat.WireType.Varint);
		L.RegConstant("Fixed64", Google.Protobuf.WireFormat.WireType.Fixed64);
		L.RegConstant("LengthDelimited", Google.Protobuf.WireFormat.WireType.LengthDelimited);
		L.RegConstant("StartGroup", Google.Protobuf.WireFormat.WireType.StartGroup);
		L.RegConstant("EndGroup", Google.Protobuf.WireFormat.WireType.EndGroup);
		L.RegConstant("Fixed32", Google.Protobuf.WireFormat.WireType.Fixed32);
		L.EndEnum();
		TypeTraits<Google.Protobuf.WireFormat.WireType>.Check = CheckType;
		StackTraits<Google.Protobuf.WireFormat.WireType>.Push = Push;
	}

	static void Push(IntPtr L, Google.Protobuf.WireFormat.WireType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(Google.Protobuf.WireFormat.WireType), L, pos);
	}
}
