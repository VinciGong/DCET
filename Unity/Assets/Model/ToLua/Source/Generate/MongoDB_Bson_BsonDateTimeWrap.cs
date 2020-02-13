﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_BsonDateTimeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.BsonDateTime), typeof(MongoDB.Bson.BsonValue));
		L.RegFunction("Create", Create);
		L.RegFunction("CompareTo", CompareTo);
		L.RegFunction("Equals", Equals);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("ToLocalTime", ToLocalTime);
		L.RegFunction("ToNullableLocalTime", ToNullableLocalTime);
		L.RegFunction("ToNullableUniversalTime", ToNullableUniversalTime);
		L.RegFunction("ToUniversalTime", ToUniversalTime);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateMongoDB_Bson_BsonDateTime);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("BsonType", get_BsonType, null);
		L.RegFunction("getBsonType", get_BsonType);
		L.RegVar("IsValidDateTime", get_IsValidDateTime, null);
		L.RegFunction("getIsValidDateTime", get_IsValidDateTime);
		L.RegVar("MillisecondsSinceEpoch", get_MillisecondsSinceEpoch, null);
		L.RegFunction("getMillisecondsSinceEpoch", get_MillisecondsSinceEpoch);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_BsonDateTime(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<long>(L, 1))
			{
				long arg0 = LuaDLL.tolua_toint64(L, 1);
				MongoDB.Bson.BsonDateTime obj = new MongoDB.Bson.BsonDateTime(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<System.DateTime>(L, 1))
			{
				System.DateTime arg0 = StackTraits<System.DateTime>.To(L, 1);
				MongoDB.Bson.BsonDateTime obj = new MongoDB.Bson.BsonDateTime(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.BsonDateTime.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.BsonDateTime arg0 = (MongoDB.Bson.BsonDateTime)ToLua.ToObject(L, 1);
			MongoDB.Bson.BsonDateTime arg1 = (MongoDB.Bson.BsonDateTime)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object arg0 = ToLua.ToVarObject(L, 1);
			MongoDB.Bson.BsonDateTime o = MongoDB.Bson.BsonDateTime.Create(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareTo(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonDateTime>(L, 2))
			{
				MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
				MongoDB.Bson.BsonDateTime arg0 = (MongoDB.Bson.BsonDateTime)ToLua.ToObject(L, 2);
				int o = obj.CompareTo(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonValue>(L, 2))
			{
				MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
				MongoDB.Bson.BsonValue arg0 = (MongoDB.Bson.BsonValue)ToLua.ToObject(L, 2);
				int o = obj.CompareTo(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: MongoDB.Bson.BsonDateTime.CompareTo");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonDateTime>(L, 2))
			{
				MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
				MongoDB.Bson.BsonDateTime arg0 = (MongoDB.Bson.BsonDateTime)ToLua.ToObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonValue>(L, 2))
			{
				MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
				MongoDB.Bson.BsonValue arg0 = (MongoDB.Bson.BsonValue)ToLua.ToObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<object>(L, 2))
			{
				MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: MongoDB.Bson.BsonDateTime.Equals");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToLocalTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
			System.DateTime o = obj.ToLocalTime();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToNullableLocalTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
			System.Nullable<System.DateTime> o = obj.ToNullableLocalTime();
			ToLua.PusNullable(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToNullableUniversalTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
			System.Nullable<System.DateTime> o = obj.ToNullableUniversalTime();
			ToLua.PusNullable(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToUniversalTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
			System.DateTime o = obj.ToUniversalTime();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)ToLua.CheckObject<MongoDB.Bson.BsonDateTime>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BsonType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)o;
			MongoDB.Bson.BsonType ret = obj.BsonType;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BsonType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsValidDateTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)o;
			bool ret = obj.IsValidDateTime;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsValidDateTime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MillisecondsSinceEpoch(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.BsonDateTime obj = (MongoDB.Bson.BsonDateTime)o;
			long ret = obj.MillisecondsSinceEpoch;
			LuaDLL.tolua_pushint64(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MillisecondsSinceEpoch on a nil value");
		}
	}
}
