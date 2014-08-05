namespace FsEPi.Controllers

open System.Diagnostics
open System.Web.Mvc
open EPiServer.Web.Mvc
open FsEPi.Models

type StartPageController() =
    inherit PageController<StartPage>()

    member x.Index(currentPage : StartPage) =
        x.View(currentPage)