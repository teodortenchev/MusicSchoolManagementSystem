namespace DubaiMusicSchool.Web.Areas.Administration.Controllers
{
    using DubaiMusicSchool.Common;
    using DubaiMusicSchool.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
