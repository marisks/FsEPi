namespace FsEPi.Models

open System.ComponentModel.DataAnnotations
open EPiServer.Core
open EPiServer.DataAnnotations

[<ContentType(DisplayName = "Start page", GUID = "2048D6E0-8D23-455B-A687-D6321F852514", Order = 10, AvailableInEditMode = true)>]
type StartPage() =
    inherit PageData()

    abstract Heading : string with get, set
    [<Display(Name = "Some heading")>] // TODO: place attributes on implementation
    default val Heading = "" with get, set