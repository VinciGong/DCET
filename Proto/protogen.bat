set LuaProtocol=..\Unity\Assets\Res\Lua\pbc\AutoGeneratedCode\
set cur=%cd%

%cur%\protoc OuterMessage.proto -o %cur%\%LuaProtocol%%OuterMessage.pb

echo protogen success
@pause