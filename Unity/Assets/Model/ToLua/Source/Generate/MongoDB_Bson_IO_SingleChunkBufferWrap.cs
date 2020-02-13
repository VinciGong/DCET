﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_IO_SingleChunkBufferWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.IO.SingleChunkBuffer), typeof(System.Object));
		L.RegFunction("AccessBackingBytes", AccessBackingBytes);
		L.RegFunction("Clear", Clear);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("EnsureCapacity", EnsureCapacity);
		L.RegFunction("GetByte", GetByte);
		L.RegFunction("GetBytes", GetBytes);
		L.RegFunction("GetSlice", GetSlice);
		L.RegFunction("MakeReadOnly", MakeReadOnly);
		L.RegFunction("SetByte", SetByte);
		L.RegFunction("SetBytes", SetBytes);
		L.RegFunction("New", _CreateMongoDB_Bson_IO_SingleChunkBuffer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Capacity", get_Capacity, null);
		L.RegFunction("getCapacity", get_Capacity);
		L.RegVar("IsReadOnly", get_IsReadOnly, null);
		L.RegFunction("getIsReadOnly", get_IsReadOnly);
		L.RegVar("Length", get_Length, set_Length);
		L.RegFunction("getLength", get_Length);
		L.RegFunction("setLength", set_Length);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_IO_SingleChunkBuffer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				MongoDB.Bson.IO.IBsonChunk arg0 = (MongoDB.Bson.IO.IBsonChunk)ToLua.CheckObject<MongoDB.Bson.IO.IBsonChunk>(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				MongoDB.Bson.IO.SingleChunkBuffer obj = new MongoDB.Bson.IO.SingleChunkBuffer(arg0, arg1);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 3)
			{
				MongoDB.Bson.IO.IBsonChunk arg0 = (MongoDB.Bson.IO.IBsonChunk)ToLua.CheckObject<MongoDB.Bson.IO.IBsonChunk>(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				MongoDB.Bson.IO.SingleChunkBuffer obj = new MongoDB.Bson.IO.SingleChunkBuffer(arg0, arg1, arg2);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.IO.SingleChunkBuffer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AccessBackingBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.ArraySegment<byte> o = obj.AccessBackingBytes(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.Clear(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnsureCapacity(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.EnsureCapacity(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			byte o = obj.GetByte(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			obj.GetBytes(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSlice(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			MongoDB.Bson.IO.IByteBuffer o = obj.GetSlice(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakeReadOnly(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			obj.MakeReadOnly();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			byte arg1 = (byte)LuaDLL.luaL_checknumber(L, 3);
			obj.SetByte(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)ToLua.CheckObject(L, 1, typeof(MongoDB.Bson.IO.SingleChunkBuffer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			obj.SetBytes(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Capacity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)o;
			int ret = obj.Capacity;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Capacity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsReadOnly(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)o;
			bool ret = obj.IsReadOnly;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsReadOnly on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Length(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)o;
			int ret = obj.Length;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Length on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Length(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.SingleChunkBuffer obj = (MongoDB.Bson.IO.SingleChunkBuffer)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Length = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Length on a nil value");
		}
	}
}
