﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DCET_Model_MonoStaticMethodWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DCET.Model.MonoStaticMethod), typeof(DCET.Model.IStaticMethod));
		L.RegFunction("Run", Run);
		L.RegFunction("New", _CreateDCET_Model_MonoStaticMethod);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDCET_Model_MonoStaticMethod(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Type arg0 = ToLua.CheckMonoType(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				DCET.Model.MonoStaticMethod obj = new DCET.Model.MonoStaticMethod(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: DCET.Model.MonoStaticMethod.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Run(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DCET.Model.MonoStaticMethod obj = (DCET.Model.MonoStaticMethod)ToLua.CheckObject<DCET.Model.MonoStaticMethod>(L, 1);
				obj.Run();
				return 0;
			}
			else if (count == 2)
			{
				DCET.Model.MonoStaticMethod obj = (DCET.Model.MonoStaticMethod)ToLua.CheckObject<DCET.Model.MonoStaticMethod>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				obj.Run(arg0);
				return 0;
			}
			else if (count == 3)
			{
				DCET.Model.MonoStaticMethod obj = (DCET.Model.MonoStaticMethod)ToLua.CheckObject<DCET.Model.MonoStaticMethod>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.Run(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				DCET.Model.MonoStaticMethod obj = (DCET.Model.MonoStaticMethod)ToLua.CheckObject<DCET.Model.MonoStaticMethod>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				object arg2 = ToLua.ToVarObject(L, 4);
				obj.Run(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DCET.Model.MonoStaticMethod.Run");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
