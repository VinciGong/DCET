﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Conventions_CamelCaseElementNameConventionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Conventions.CamelCaseElementNameConvention), typeof(MongoDB.Bson.Serialization.Conventions.ConventionBase));
		L.RegFunction("Apply", Apply);
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Conventions_CamelCaseElementNameConvention);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Conventions_CamelCaseElementNameConvention(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Conventions.CamelCaseElementNameConvention obj = new MongoDB.Bson.Serialization.Conventions.CamelCaseElementNameConvention();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Conventions.CamelCaseElementNameConvention.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.Serialization.Conventions.CamelCaseElementNameConvention obj = (MongoDB.Bson.Serialization.Conventions.CamelCaseElementNameConvention)ToLua.CheckObject<MongoDB.Bson.Serialization.Conventions.CamelCaseElementNameConvention>(L, 1);
			MongoDB.Bson.Serialization.BsonMemberMap arg0 = (MongoDB.Bson.Serialization.BsonMemberMap)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonMemberMap>(L, 2);
			obj.Apply(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
