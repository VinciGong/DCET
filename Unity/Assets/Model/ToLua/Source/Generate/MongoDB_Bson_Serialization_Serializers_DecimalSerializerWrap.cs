﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_DecimalSerializerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.DecimalSerializer), typeof(MongoDB.Bson.Serialization.Serializers.StructSerializerBase<decimal>));
		L.RegFunction("Deserialize", Deserialize);
		L.RegFunction("Serialize", Serialize);
		L.RegFunction("WithConverter", WithConverter);
		L.RegFunction("WithRepresentation", WithRepresentation);
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Serializers_DecimalSerializer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Converter", get_Converter, null);
		L.RegFunction("getConverter", get_Converter);
		L.RegVar("Representation", get_Representation, null);
		L.RegFunction("getRepresentation", get_Representation);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Serializers_DecimalSerializer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = new MongoDB.Bson.Serialization.Serializers.DecimalSerializer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				MongoDB.Bson.BsonType arg0 = (MongoDB.Bson.BsonType)LuaDLL.luaL_checknumber(L, 1);
				MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = new MongoDB.Bson.Serialization.Serializers.DecimalSerializer(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2)
			{
				MongoDB.Bson.BsonType arg0 = (MongoDB.Bson.BsonType)LuaDLL.luaL_checknumber(L, 1);
				MongoDB.Bson.Serialization.Options.RepresentationConverter arg1 = (MongoDB.Bson.Serialization.Options.RepresentationConverter)ToLua.CheckObject<MongoDB.Bson.Serialization.Options.RepresentationConverter>(L, 2);
				MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = new MongoDB.Bson.Serialization.Serializers.DecimalSerializer(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Serializers.DecimalSerializer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Deserialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = (MongoDB.Bson.Serialization.Serializers.DecimalSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.DecimalSerializer>(L, 1);
			MongoDB.Bson.Serialization.BsonDeserializationContext arg0 = (MongoDB.Bson.Serialization.BsonDeserializationContext)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonDeserializationContext>(L, 2);
			MongoDB.Bson.Serialization.BsonDeserializationArgs arg1 = StackTraits<MongoDB.Bson.Serialization.BsonDeserializationArgs>.Check(L, 3);
			decimal o = obj.Deserialize(arg0, arg1);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Serialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = (MongoDB.Bson.Serialization.Serializers.DecimalSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.DecimalSerializer>(L, 1);
			MongoDB.Bson.Serialization.BsonSerializationContext arg0 = (MongoDB.Bson.Serialization.BsonSerializationContext)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonSerializationContext>(L, 2);
			MongoDB.Bson.Serialization.BsonSerializationArgs arg1 = StackTraits<MongoDB.Bson.Serialization.BsonSerializationArgs>.Check(L, 3);
			decimal arg2 = StackTraits<decimal>.Check(L, 4);
			obj.Serialize(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WithConverter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = (MongoDB.Bson.Serialization.Serializers.DecimalSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.DecimalSerializer>(L, 1);
			MongoDB.Bson.Serialization.Options.RepresentationConverter arg0 = (MongoDB.Bson.Serialization.Options.RepresentationConverter)ToLua.CheckObject<MongoDB.Bson.Serialization.Options.RepresentationConverter>(L, 2);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer o = obj.WithConverter(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WithRepresentation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = (MongoDB.Bson.Serialization.Serializers.DecimalSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.DecimalSerializer>(L, 1);
			MongoDB.Bson.BsonType arg0 = (MongoDB.Bson.BsonType)LuaDLL.luaL_checknumber(L, 2);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer o = obj.WithRepresentation(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Converter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = (MongoDB.Bson.Serialization.Serializers.DecimalSerializer)o;
			MongoDB.Bson.Serialization.Options.RepresentationConverter ret = obj.Converter;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Converter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Representation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Serializers.DecimalSerializer obj = (MongoDB.Bson.Serialization.Serializers.DecimalSerializer)o;
			MongoDB.Bson.BsonType ret = obj.Representation;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Representation on a nil value");
		}
	}
}
