-- Generated by CSharp.lua Compiler
local System = System
System.namespace("DCET.Hotfix", function (namespace)
  namespace.interface("IDestroySystem", function ()
    return {}
  end)

  namespace.class("DestroySystem_1", function (namespace)
    return function (T)
      local Run, Type
      Run = function (this, o)
        this:Destroy(System.cast(T, o))
      end
      Type = function (this)
        return System.typeof(T)
      end
      return {
        base = function (out)
          return {
            out.DCET.Hotfix.IDestroySystem
          }
        end,
        Run = Run,
        Type = Type
      }
    end
  end)
end)