namespace FsEPi.Models

open EPiServer.Core
open EPiServer.DataAnnotations

[<ContentType(DisplayName = "Start page", GUID = "2048D6E0-8D23-455B-A687-D6321F852514", Order = 10, AvailableInEditMode = true)>]
type StartPage() =
    inherit PageData()