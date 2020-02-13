-- Generated by CSharp.lua Compiler
local System = System
local DCETHotfix = DCET.Hotfix
local DCETHotfix
local ListIMHandler
local DictUInt16ListIMHandler
System.import(function (out)
  DCETHotfix = DCET.Hotfix
  ListIMHandler = System.List(DCETHotfix.IMHandler)
  DictUInt16ListIMHandler = System.Dictionary(System.UInt16, ListIMHandler)
end)
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("MessageDispatcherComponentAwakeSystem", function (namespace)
    local Awake
    Awake = function (this, t)
      t:Awake()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.AwakeSystem_1(out.DCET.Hotfix.MessageDispatcherComponent)
        }
      end,
      Awake = Awake,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.Hotfix.ObjectSystemAttribute() }
        }
      end
    }
  end)

  namespace.class("MessageDispatcherComponentLoadSystem", function (namespace)
    local Load
    Load = function (this, self)
      self:Load()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.LoadSystem_1(out.DCET.Hotfix.MessageDispatcherComponent)
        }
      end,
      Load = Load,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.Hotfix.ObjectSystemAttribute() }
        }
      end
    }
  end)

  -- <summary>
  -- 消息分发组件
  -- </summary>
  namespace.class("MessageDispatcherComponent", function (namespace)
    local Awake, Load, RegisterHandler, Handle, Dispose, __ctor__
    __ctor__ = function (this)
      this.handlers = DictUInt16ListIMHandler()
      DCETHotfix.Entity.__ctor__(this)
    end
    Awake = function (this)
      Load(this)
    end
    Load = function (this)
      this.handlers:Clear()

      local types = DCETHotfix.Game.getEventSystem():GetTypes(System.typeof(DCETHotfix.MessageHandlerAttribute))

      for _, type in System.each(types) do
        local continue
        repeat
          local attrs = type:GetCustomAttributes(System.typeof(DCETHotfix.MessageHandlerAttribute), false)
          if #attrs == 0 then
            continue = true
            break
          end

          local iMHandler = System.as(System.Activator.CreateInstance(type), DCETHotfix.IMHandler)
          if iMHandler == nil then
            DCETHotfix.Log.Error1("message handle " .. type:getName() .. " 需要继承 IMHandler")
            continue = true
            break
          end

          local messageType = iMHandler:GetMessageType()
          local opcode = this:getParent():GetComponent(DCETHotfix.OpcodeTypeComponent):GetOpcode(messageType)
          if opcode == 0 then
            DCETHotfix.Log.Error1("消息opcode为0: " .. messageType:getName())
            continue = true
            break
          end
          RegisterHandler(this, opcode, iMHandler)
          continue = true
        until 1
        if not continue then
          break
        end
      end
    end
    RegisterHandler = function (this, opcode, handler)
      if not this.handlers:ContainsKey(opcode) then
        this.handlers:AddKeyValue(opcode, ListIMHandler())
      end
      this.handlers:get(opcode):Add(handler)
    end
    Handle = function (this, session, messageInfo)
      local actions
      local default
      default, actions = this.handlers:TryGetValue(messageInfo.Opcode)
      if not default then
        DCETHotfix.Log.Error1("消息没有处理: " .. messageInfo.Opcode .. " " .. DCETHotfix.JsonHelper.ToJson(messageInfo.Message))
        return
      end

      for _, ev in System.each(actions) do
        System.try(function ()
          ev:Handle(session, messageInfo.Message)
        end, function (default)
          local e = default
          DCETHotfix.Log.Error(e)
        end)
      end
    end
    Dispose = function (this)
      if this:getIsDisposed() then
        return
      end

      DCETHotfix.Entity.Dispose(this)
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.Entity
        }
      end,
      Awake = Awake,
      Load = Load,
      RegisterHandler = RegisterHandler,
      Handle = Handle,
      Dispose = Dispose,
      __ctor__ = __ctor__
    }
  end)
end)