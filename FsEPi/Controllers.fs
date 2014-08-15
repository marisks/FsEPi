namespace FsEPi.Controllers

open EPiServer
open EPiServer.ServiceLocation
open EPiServer.Web.Mvc
open FsEPi.Models

type StartPageController() =
    inherit PageController<StartPage>()

    member x.Index(currentPage:StartPage) =
        let contentRepo = ServiceLocator.Current.GetInstance<IContentRepository>()
        // Trying out to get property values by calling repo, but still same result
        // page.Property (property on ContentData base class) contains values, but StartPage properties are not set
        let page = contentRepo.Get<StartPage>(currentPage.ContentLink)
        x.View(page)

    member x.GetCurrentPage() =
        base.PageContext.Page :?> StartPage