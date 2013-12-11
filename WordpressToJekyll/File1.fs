module File1

open System.Xml.Linq
open FSharp.Data


    type ReadSample() = 
        type posts = FSharp.Data.XmlProvider<"roundcrisis-wordpress.xml">
        let  sample =posts.GetSample()
        sprintf sample
    