namespace FsEPi.Models

open System.ComponentModel.DataAnnotations
open EPiServer.Core
open EPiServer.DataAnnotations

[<ContentType(DisplayName = "Start page", GUID = "2048D6E0-8D23-455B-A687-D6321F852514")>]
type StartPage() =
    inherit PageData()

    abstract Heading : string with get, set
    [<Display(Name = "Some heading")>] // placing attributes on implementation
    default val Heading = "" with get, set

    abstract IAmNew : string with get, set
    [<Display(Name = "I am new")>] // placing attributes on implementation
    default val IAmNew = "" with get, set
    
    abstract IAmNewBool : bool with get, set
    [<Display(Name = "I am new bool")>] // placing attributes on implementation
    default val IAmNewBool = false with get, set
