﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_IO_IBsonReaderExtensionsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("IBsonReaderExtensions");
		L.RegFunction("FindElement", FindElement);
		L.RegFunction("FindStringElement", FindStringElement);
		L.RegFunction("ReadBinaryData", ReadBinaryData);
		L.RegFunction("ReadBoolean", ReadBoolean);
		L.RegFunction("ReadBytes", ReadBytes);
		L.RegFunction("ReadDateTime", ReadDateTime);
		L.RegFunction("ReadDecimal128", ReadDecimal128);
		L.RegFunction("ReadDouble", ReadDouble);
		L.RegFunction("ReadInt32", ReadInt32);
		L.RegFunction("ReadInt64", ReadInt64);
		L.RegFunction("ReadJavaScript", ReadJavaScript);
		L.RegFunction("ReadJavaScriptWithScope", ReadJavaScriptWithScope);
		L.RegFunction("ReadMaxKey", ReadMaxKey);
		L.RegFunction("ReadMinKey", ReadMinKey);
		L.RegFunction("ReadName", ReadName);
		L.RegFunction("ReadNull", ReadNull);
		L.RegFunction("ReadObjectId", ReadObjectId);
		L.RegFunction("ReadRawBsonArray", ReadRawBsonArray);
		L.RegFunction("ReadRawBsonDocument", ReadRawBsonDocument);
		L.RegFunction("ReadRegularExpression", ReadRegularExpression);
		L.RegFunction("ReadString", ReadString);
		L.RegFunction("ReadSymbol", ReadSymbol);
		L.RegFunction("ReadTimestamp", ReadTimestamp);
		L.RegFunction("ReadUndefined", ReadUndefined);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindElement(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			bool o = MongoDB.Bson.IO.IBsonReaderExtensions.FindElement(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindStringElement(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string o = MongoDB.Bson.IO.IBsonReaderExtensions.FindStringElement(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBinaryData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.BsonBinaryData o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadBinaryData(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBoolean(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			bool o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadBoolean(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			byte[] o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadBytes(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadDateTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			long o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadDateTime(arg0, arg1);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadDecimal128(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.Decimal128 o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadDecimal128(arg0, arg1);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadDouble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			double o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadDouble(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadInt32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			int o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadInt32(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadInt64(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			long o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadInt64(arg0, arg1);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadJavaScript(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadJavaScript(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadJavaScriptWithScope(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadJavaScriptWithScope(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadMaxKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.IO.IBsonReaderExtensions.ReadMaxKey(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadMinKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.IO.IBsonReaderExtensions.ReadMinKey(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadName(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
				string o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadName(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 2)
			{
				MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				MongoDB.Bson.IO.IBsonReaderExtensions.ReadName(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: MongoDB.Bson.IO.IBsonReaderExtensions.ReadName");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadNull(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.IO.IBsonReaderExtensions.ReadNull(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadObjectId(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.ObjectId o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadObjectId(arg0, arg1);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadRawBsonArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.IO.IByteBuffer o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadRawBsonArray(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadRawBsonDocument(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.IO.IByteBuffer o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadRawBsonDocument(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadRegularExpression(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.BsonRegularExpression o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadRegularExpression(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadString(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadSymbol(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadSymbol(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadTimestamp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			long o = MongoDB.Bson.IO.IBsonReaderExtensions.ReadTimestamp(arg0, arg1);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadUndefined(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.IBsonReader arg0 = (MongoDB.Bson.IO.IBsonReader)ToLua.CheckObject<MongoDB.Bson.IO.IBsonReader>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			MongoDB.Bson.IO.IBsonReaderExtensions.ReadUndefined(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
