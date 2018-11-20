using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chen_Xuxian_HW5.DAL;
using Chen_Xuxian_HW5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Chen_Xuxian_HW5.Controllers
{
    public enum GreaterOrLesser { All, Greater, Less}

    public class HomeController : Controller
    {
        Int32 intNumberOfStars;

        private AppDbContext _db;

        public HomeController(AppDbContext context)
        {
            _db = context;
        }

        // GET: Home.Index.QuickSearch
        public IActionResult Index(String SearchString)
        {
            List<Repository> SelectedRepositories = new List<Repository>();

            var query = from r in _db.Repositories
                        select r;

            if (_db.Repositories.Count() == 0)
            {
                return RedirectToAction("Index", "Seed");
            }

            if (SearchString != null && SearchString != "")
            {
                query = query.Where(r => r.RepositoryName.Contains(SearchString) || 
                                                        r.UserName.Contains(SearchString));
            }

            SelectedRepositories = query.Include(r => r.Language).ToList();

            ViewBag.TotalRepositories = _db.Repositories.Count();
            ViewBag.SelectedRepositories = SelectedRepositories.Count();

            return View(SelectedRepositories.OrderByDescending(r => r.StarCount));            
        }

        public IActionResult Details(int? id)
        {
            if (id == null) //Repo id not specified
            {
                return View("Error", new String[] { "Repository ID not specified - which repo do you want to view?" });
            }

            Repository repo = _db.Repositories.Include(r => r.Language).FirstOrDefault(r => r.RepositoryID == id);

            if (repo == null) //Repo does not exist in database
            {
                return View("Error", new String[] { "Repository not found in database" });
            }

            //if code gets this far, all is well
            return View(repo);

        }


        public SelectList GetAllLanguages()
        {
            //Get the list from the other class
            List<Language> Languages = _db.Languages.ToList();

            Language SelectNone = new Language() {LanguageID = 0, Name = "All Languages" };
            Languages.Add(SelectNone);

            //convert list to multiselect list
            SelectList AllLanguages = new SelectList(Languages.OrderBy(d => d.LanguageID), "LanguageID", "Name");

            //return the multiselect list
            return AllLanguages;
        }

        public SelectList GetAllRepositories()
        {
            //Get the list from the other class
            List<Repository> Repositories = _db.Repositories.ToList();

            //convert list to select list
            SelectList AllRepositories = new SelectList(Repositories.OrderBy(r => r.RepositoryID), "RepositoryID", "RepositoryName");

            //return the select list
            return AllRepositories;
        }

        public ActionResult DetailedSearch()
        {
            ViewBag.AllRepositories = GetAllRepositories();
            ViewBag.AllLanguages = GetAllLanguages();
            return View();
        }

        public ActionResult DisplaySearchResults(String strSearchName, String strSearchDescription, int SelectedLanguage, String strNumberOfStars, GreaterOrLesser GreatOrLess, DateTime? datLastModified)
        {
            //First search box.
            if (strSearchName == null || strSearchName == "")
            {
                ViewBag.strSearchName = "Name string was null";
            }
            else //they picked something
            {
                ViewBag.strSearchName = "The name search string is " + strSearchName;
            }
            //Second search box.
            if (strSearchDescription == null || strSearchDescription == "")
            {
                ViewBag.strSearchDescription = "Description string was null";
            }
            else //they picked something
            {
                ViewBag.strSearchDescription = "The name search string is " + strSearchDescription;
            }
            //Drop down list for language.
            if (SelectedLanguage == 0) // they chose "all languages from the drop-down
            {
                ViewBag.SelectedLanguage = "No Language was selected";
            }
            else 
            {
                Language LanguageToDisplay = _db.Languages.Find(SelectedLanguage);
                ViewBag.SelectedLanguage = "The selected Language is " + LanguageToDisplay.Name;
            }
            //Third search box.
            if (strNumberOfStars == null || strNumberOfStars == "")
            {
                ViewBag.strNumberOfStars = "Number of Star selected is null";
            }
            else //they picked something
            {
                try
                {
                    intNumberOfStars = Convert.ToInt32(strNumberOfStars);
                }
                catch  //this code will display when something is wrong
                {
                    //Add a message for the viewbag
                    ViewBag.Message = strSearchDescription + "is not valid number. Please try again";

                    ViewBag.AllRepositories = GetAllRepositories();
                    ViewBag.AllLanguages = GetAllLanguages();
                    return View();
                }
                ViewBag.strNumberOfStars = "The Number of Star wanted is " + strNumberOfStars;
            }
            //Greater or Less than Option
            switch (GreatOrLess)
            {
                case GreaterOrLesser.Greater:
                    ViewBag.GreatOrLess = "Greater is selected";
                    break;
                case GreaterOrLesser.Less:
                    ViewBag.GreatOrLess = "Less is selected";
                    break;               
                default:
                    ViewBag.GreatOrLess = "No classification selected";
                    break;
            }
            //datLastModified.
            if (datLastModified != null)
            {
                DateTime datSelected = datLastModified ?? new DateTime(1900, 1, 1);
                ViewBag.datLastModified = "The selected date is " + datSelected.ToLongDateString();
            }
            else //They didn't pick a date
            {
                ViewBag.datLastModified = "No date was selected";
            }

            //var query = from r in _db.Repositories
            //             where (r.RepositoryName.Contains(strSearchName) ||
            //                                            r.UserName.Contains(strSearchName) &&
            //                                            r.Description.Contains(strSearchDescription) &&
            //                                            r.Language.LanguageID == SelectedLanguage &&
            //                                            r.LastUpdate >= (datLastModified))
            //             select r;
            var query1 = from r in _db.Repositories
                         select r;
            var query2 = from r in _db.Repositories
                        select r;
            var query3 = from r in _db.Repositories
                        select r;
            var query4 = from r in _db.Repositories
                        select r;
            var query5 = from r in _db.Repositories
                         select r;

            List<Repository> SelectedRepositories = new List<Repository>();

            if (strSearchName != null && strSearchName != "")
            {
                query1 = query1.Where(r => r.RepositoryName.Contains(strSearchName) ||
                                                        r.UserName.Contains(strSearchName));
            }
            if (strSearchDescription != null && strSearchDescription != "")
            {
                query2 = query2.Where(r => r.Description.Contains(strSearchDescription));
            }
            if (SelectedLanguage != 0)
            {
                query3 = query3.Where(r => r.Language.LanguageID == SelectedLanguage);
            }
            if (GreatOrLess == GreaterOrLesser.Greater)
            { query4 = query4.Where(r => r.StarCount >= intNumberOfStars); }
            if (GreatOrLess == GreaterOrLesser.Less)
            { query4 = query4.Where(r => r.StarCount <= intNumberOfStars); }
            if (datLastModified != null)
            {
                query5 = query5.Where(r => r.LastUpdate >= (datLastModified));
            }

            var combi = query1.Intersect(query2.Intersect(query3).Intersect(query4.Intersect(query5))).Include(r => r.Language);
            
            SelectedRepositories = combi.ToList();
            //SelectedRepositories = query.Include(r => r.Language).ToList();
            ViewBag.TotalRepositories = _db.Repositories.Count();
            ViewBag.SelectedRepositories = SelectedRepositories.Count();

            return View("Index", SelectedRepositories.OrderByDescending(r => r.StarCount));
        }
    }
}