﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("MessageRouter")>]
[<assembly: AssemblyProductAttribute("MessageRouter")>]
[<assembly: AssemblyDescriptionAttribute("MessageRouter")>]
[<assembly: AssemblyVersionAttribute("2.0.0")>]
[<assembly: AssemblyFileVersionAttribute("2.0.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.0.0"
