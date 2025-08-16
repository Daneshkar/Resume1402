using Microsoft.AspNetCore.Mvc;
using Resume.Domain.Entities.MySkills;
using Reume.Application.Services.Implement;
using Reume.Application.Services.Interface;

namespace Resume.Presenation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class MySkillsController : Controller
{
    #region ctor

    private readonly IMySkillService _mySkillService;
    public MySkillsController(IMySkillService mySkillService)
    {
        _mySkillService = mySkillService;
    }

    #endregion

    #region List of My Skills 

    [HttpGet]
    public IActionResult ListOfMySkills()
        => View(_mySkillService.GetListOfMySkills());

    #endregion

    #region Create MySkill

    [HttpGet]
    public IActionResult CreateMySkill()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult CreateMySkill(MySkills model)
    {
        if (ModelState.IsValid)
        {
            _mySkillService.CreateMySkill(model);

            return RedirectToAction(nameof(ListOfMySkills));
        }

        return View();
    }

    #endregion

    #region Edit MySkill

    [HttpGet]
    public IActionResult EditMySkill(int skillId)
    {
        var mySkill = _mySkillService.FindOne(skillId);
        if (mySkill == null)
            return NotFound();

        return View(mySkill);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult EditMySkill(MySkills mySkill)
    {
        _mySkillService.UpdateMySkill(mySkill);

        return RedirectToAction(nameof(ListOfMySkills));
    }

    #endregion

    #region Delete MySkill

    [HttpGet]
    public IActionResult DeleteMySkill(int skillId)
    {
        var mySkill = _mySkillService.FindOne(skillId);
        if (mySkill == null)
            return NotFound();

        return View(mySkill);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult DeleteMySkill(MySkills mySkill)
    {
        _mySkillService.DeleteMySkill(mySkill);
        return RedirectToAction(nameof(ListOfMySkills));
    }

    #endregion
}
