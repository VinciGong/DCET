﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_GraphDebugModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(PF.GraphDebugMode));
		L.RegConstant("Areas", PF.GraphDebugMode.Areas);
		L.RegConstant("G", PF.GraphDebugMode.G);
		L.RegConstant("H", PF.GraphDebugMode.H);
		L.RegConstant("F", PF.GraphDebugMode.F);
		L.RegConstant("Penalty", PF.GraphDebugMode.Penalty);
		L.RegConstant("Connections", PF.GraphDebugMode.Connections);
		L.RegConstant("Tags", PF.GraphDebugMode.Tags);
		L.EndEnum();
		TypeTraits<PF.GraphDebugMode>.Check = CheckType;
		StackTraits<PF.GraphDebugMode>.Push = Push;
	}

	static void Push(IntPtr L, PF.GraphDebugMode arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(PF.GraphDebugMode), L, pos);
	}
}
