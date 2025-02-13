# App with Plugin

Link : https://learn.microsoft.com/en-us/dotnet/core/tutorials/creating-app-with-plugin-support

![UML](https://img.plantuml.biz/plantuml/png/lLDTIyCm57tFhmZuKXdz0wFKoJQne584yK54ikPQ0_aOD-dOcFllfh7jiitXa_Ob9FUSd7DoRoVMCNIDagIIp5fQegcHARebr7yftVgw4zMEtZEX4uQr7Lk7GjSlhvTqJ5T6y80SS2czCuoNigaz7a7wqnMKp7rql9PrRIseXTmSCwS8pC7KACKqjmdhOECUttABkMuK85j8o8eEcfCTwVq7uTR2r6W7QpSaUKEmHgu08mCpM8BceAlDOrSCuD7fDSaodCH10lI2PfdnF1GSyZna7tm_C0M3ztOJPxywHt_IFXAhWS-aJ9fe4wxRFsAXNUbmd_n6oFxfkimZsb8yz9lafMfmUTxLPc0h54idZ3u7cQ-XQXmahPpGRgzr2rAQ_n9xDYZvtulv1V2TLK2BGx7pKhyA_I3JzpyUqUmpJKz7Zf31I0143JwgnEquAiMFHoP-sFsl_WK0 "aa")

```plantuml
@startuml
class PluginLoadContext {
    - _resolver : AssemblyDependencyResolver
    + PluginLoadContext(pluginPath:string)
    # <<override>> Load(assemblyName:AssemblyName) : Assembly?
    # <<override>> LoadUnmanagedDll(unmanagedDllName:string) : IntPtr
}
AssemblyLoadContext <|-- PluginLoadContext

class FileCommand {
    + Name : string <<get>>
    + Description : string <<get>>
    + Execute() : int
}
ICommand <|-- FileCommand

class HelloCommand {
    + Name : string <<get>>
    + Description : string <<get>>
    + Execute() : int
}
ICommand <|-- HelloCommand

class WorldCommand {
    + Name : string <<get>>
    + Description : string <<get>>
    + Execute() : int
}
ICommand <|-- WorldCommand

interface ICommand {
    Name : string <<get>>
    Description : string <<get>>
    Execute() : int
}

class Program {
    - {static} Main(args:string[]) : void
    {static} - LoadPlugin(relativePath:string) : Assembly
    {static} - CreateCommands(assembly:Assembly) : IEnumerable<ICommand>
}
@enduml
```
