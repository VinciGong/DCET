-- Generated by CSharp.lua Compiler
local System = System
local UnityEngine = UnityEngine
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("OperaComponentAwakeSystem", function (namespace)
    local Awake
    Awake = function (this, self)
      self:Awake()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.AwakeSystem_1(out.DCET.Hotfix.OperaComponent)
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

  namespace.class("OperaComponentUpdateSystem", function (namespace)
    local Update
    Update = function (this, self)
      self:Update()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.UpdateSystem_1(out.DCET.Hotfix.OperaComponent)
        }
      end,
      Update = Update,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.Hotfix.ObjectSystemAttribute() }
        }
      end
    }
  end)

  namespace.class("OperaComponent", function (namespace)
    local Awake, Update, TestActor, __ctor__
    __ctor__ = function (this)
      this.ClickPoint = System.default(UnityEngine.Vector3)
      System.base(this).__ctor__(this)
    end
    Awake = function (this)
      this.mapMask = UnityEngine.LayerMask.GetMask("Map")
    end
    Update = function (this)
      if UnityEngine.Input.GetMouseButtonDown(1) then
        local ray = UnityEngine.Camera.getmain():ScreenPointToRay(UnityEngine.Input.getmousePosition())
        local hit
        local default
        default, hit = UnityEngine.Physics.Raycast(ray, nil, 1000, this.mapMask)
        if default then
          this.ClickPoint = hit.point:__clone__()
          --[[frameClickMap.X = this.ClickPoint.x;
		            frameClickMap.Y = this.ClickPoint.y;
		            frameClickMap.Z = this.ClickPoint.z;
		            SessionComponent.Instance.Session.Send(frameClickMap);]]

          -- 测试actor rpc消息
          TestActor(this)
        end
      end
    end
    TestActor = function (this)
      System.async(function (async, this)
        --[[try
		    {
			    M2C_TestActorResponse response = (M2C_TestActorResponse)await SessionComponent.Instance.Session.Call(
						new C2M_TestActorRequest() { Info = "actor rpc request" });
			    Log.Info(response.Info);
			}
		    catch (Exception e)
		    {
				Log.Error(e);
		    }]]
      end, true, this)
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.Entity
        }
      end,
      mapMask = 0,
      Awake = Awake,
      Update = Update,
      TestActor = TestActor,
      __ctor__ = __ctor__
    }
  end)
end)