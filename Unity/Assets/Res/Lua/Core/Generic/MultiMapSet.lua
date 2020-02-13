-- Generated by CSharp.lua Compiler
local System = System
local Linq = System.Linq.Enumerable
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("MultiMapSet_2", function (namespace)
    return function (T, K)
      local queue, Empty, GetDictionary, Add, First, FirstKey, getCount, FetchList, 
      RecycleList, Remove, Remove1, GetAll, get, GetOne, Contains, ContainsKey, 
      Clear, static, __ctor__
      local ArrayK = System.Array(K)
      local HashSetK = System.HashSet(K)
      local DictTHashSetK = System.Dictionary(T, HashSetK)
      local QueueHashSetK = System.Queue(HashSetK)
      static = function (this)
        queue = QueueHashSetK()
        Empty = HashSetK()
      end
      __ctor__ = function (this)
        this.dictionary = DictTHashSetK()
      end
      GetDictionary = function (this)
        return this.dictionary
      end
      Add = function (this, t, k)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          list = FetchList(this)
          this.dictionary:set(t, list)
        end
        list:Add(k)
      end
      First = function (this)
        return Linq.First(this.dictionary)
      end
      FirstKey = function (this)
        return Linq.First(this.dictionary:getKeys())
      end
      getCount = function (this)
        return this.dictionary:getCount()
      end
      FetchList = function (this)
        if #queue > 0 then
          local list = queue:Dequeue()
          list:Clear()
          return list
        end
        return HashSetK()
      end
      RecycleList = function (this, list)
        list:Clear()
        queue:Enqueue(list)
      end
      Remove = function (this, t, k)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          return false
        end
        if not list:Remove(k) then
          return false
        end
        if list:getCount() == 0 then
          RecycleList(this, list)
          this.dictionary:RemoveKey(t)
        end
        return true
      end
      Remove1 = function (this, t)
        local list = nil
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list ~= nil then
          RecycleList(this, list)
        end
        return this.dictionary:RemoveKey(t)
      end
      -- <summary>
      -- 不返回内部的list,copy一份出来
      -- </summary>
      -- <returns></returns>
      GetAll = function (this, t)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          return ArrayK:new(0)
        end
        return Linq.ToArray(list)
      end
      get = function (this, t)
        local _, list = this.dictionary:TryGetValue(t)
        return list or Empty
      end
      GetOne = function (this, t)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list ~= nil and list:getCount() > 0 then
          return Linq.FirstOrDefault(list)
        end
        return System.default(K)
      end
      Contains = function (this, t, k)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          return false
        end
        return list:Contains(k)
      end
      ContainsKey = function (this, t)
        return this.dictionary:ContainsKey(t)
      end
      Clear = function (this)
        for _, list in System.each(this.dictionary:getValues()) do
          list:Clear()
          queue:Enqueue(list)
        end
        this.dictionary:Clear()
      end
      return {
        GetDictionary = GetDictionary,
        Add = Add,
        First = First,
        FirstKey = FirstKey,
        getCount = getCount,
        Remove = Remove,
        Remove1 = Remove1,
        GetAll = GetAll,
        get = get,
        GetOne = GetOne,
        Contains = Contains,
        ContainsKey = ContainsKey,
        Clear = Clear,
        static = static,
        __ctor__ = __ctor__
      }
    end
  end)
end)