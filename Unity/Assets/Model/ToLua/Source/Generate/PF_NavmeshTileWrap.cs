﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_NavmeshTileWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.NavmeshTile), typeof(System.Object));
		L.RegFunction("GetTileCoordinates", GetTileCoordinates);
		L.RegFunction("GetVertexArrayIndex", GetVertexArrayIndex);
		L.RegFunction("GetVertex", GetVertex);
		L.RegFunction("GetVertexInGraphSpace", GetVertexInGraphSpace);
		L.RegFunction("GetNodes", GetNodes);
		L.RegFunction("New", _CreatePF_NavmeshTile);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("tris", get_tris, set_tris);
		L.RegVar("verts", get_verts, set_verts);
		L.RegVar("vertsInGraphSpace", get_vertsInGraphSpace, set_vertsInGraphSpace);
		L.RegVar("x", get_x, set_x);
		L.RegVar("z", get_z, set_z);
		L.RegVar("w", get_w, set_w);
		L.RegVar("d", get_d, set_d);
		L.RegVar("nodes", get_nodes, set_nodes);
		L.RegVar("bbTree", get_bbTree, set_bbTree);
		L.RegVar("flag", get_flag, set_flag);
		L.RegVar("graph", get_graph, set_graph);
		L.RegVar("transform", get_transform, null);
		L.RegFunction("gettransform", get_transform);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_NavmeshTile(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				PF.NavmeshTile obj = new PF.NavmeshTile();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.NavmeshTile.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTileCoordinates(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			PF.NavmeshTile obj = (PF.NavmeshTile)ToLua.CheckObject<PF.NavmeshTile>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1;
			int arg2;
			obj.GetTileCoordinates(arg0, out arg1, out arg2);
			LuaDLL.lua_pushinteger(L, arg1);
			LuaDLL.lua_pushinteger(L, arg2);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertexArrayIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.NavmeshTile obj = (PF.NavmeshTile)ToLua.CheckObject<PF.NavmeshTile>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = obj.GetVertexArrayIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.NavmeshTile obj = (PF.NavmeshTile)ToLua.CheckObject<PF.NavmeshTile>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			PF.Int3 o = obj.GetVertex(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertexInGraphSpace(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.NavmeshTile obj = (PF.NavmeshTile)ToLua.CheckObject<PF.NavmeshTile>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			PF.Int3 o = obj.GetVertexInGraphSpace(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNodes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.NavmeshTile obj = (PF.NavmeshTile)ToLua.CheckObject<PF.NavmeshTile>(L, 1);
			System.Action<PF.GraphNode> arg0 = (System.Action<PF.GraphNode>)ToLua.CheckDelegate<System.Action<PF.GraphNode>>(L, 2);
			obj.GetNodes(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tris(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int[] ret = obj.tris;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tris on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verts(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.Int3[] ret = obj.verts;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verts on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_vertsInGraphSpace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.Int3[] ret = obj.vertsInGraphSpace;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index vertsInGraphSpace on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int ret = obj.x;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index x on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int ret = obj.z;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index z on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_w(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int ret = obj.w;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index w on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_d(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int ret = obj.d;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index d on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nodes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.TriangleMeshNode[] ret = obj.nodes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nodes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bbTree(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.BBTree ret = obj.bbTree;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bbTree on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			bool ret = obj.flag;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index flag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_graph(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.NavmeshBase ret = obj.graph;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index graph on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.GraphTransform ret = obj.transform;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tris(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.tris = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tris on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verts(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.Int3[] arg0 = ToLua.CheckStructArray<PF.Int3>(L, 2);
			obj.verts = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verts on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_vertsInGraphSpace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.Int3[] arg0 = ToLua.CheckStructArray<PF.Int3>(L, 2);
			obj.vertsInGraphSpace = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index vertsInGraphSpace on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.x = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index x on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.z = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index z on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_w(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.w = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index w on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_d(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.d = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index d on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_nodes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.TriangleMeshNode[] arg0 = ToLua.CheckObjectArray<PF.TriangleMeshNode>(L, 2);
			obj.nodes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nodes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bbTree(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.BBTree arg0 = (PF.BBTree)ToLua.CheckObject<PF.BBTree>(L, 2);
			obj.bbTree = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bbTree on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.flag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index flag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_graph(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshTile obj = (PF.NavmeshTile)o;
			PF.NavmeshBase arg0 = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 2);
			obj.graph = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index graph on a nil value");
		}
	}
}
