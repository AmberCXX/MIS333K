using System;
using System.Collections.Generic;
using Chen_Xuxian_HW5.DAL;
using Chen_Xuxian_HW5.Models;
using System.Linq;

namespace Chen_Xuxian_HW5.Seeding
{
    public static class SeedLanguages
    {
        public static void SeedAllLanguages(AppDbContext db)
        {
            //check to see if all the languages have already been added
            if (db.Languages.Count() == 21)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Language record count is already 21!");
                throw ex;
            }
            Int32 intLanguagesAdded = 0;
            try
            {
                //Create a list of languages
                List<Language> Languages = new List<Language>();

                Language l1 = new Language { Name = "Assembly" };
                Languages.Add(l1);

                Language l2 = new Language { Name = "C" };
                Languages.Add(l2);

                Language l3 = new Language { Name = "C++" };
                Languages.Add(l3);

                Language l4 = new Language { Name = "Clojure" };
                Languages.Add(l4);

                Language l5 = new Language { Name = "CoffeeScript" };
                Languages.Add(l5);

                Language l6 = new Language { Name = "CSS" };
                Languages.Add(l6);

                Language l7 = new Language { Name = "Go" };
                Languages.Add(l7);

                Language l8 = new Language { Name = "HTML" };
                Languages.Add(l8);

                Language l9 = new Language { Name = "Java" };
                Languages.Add(l9);

                Language l10 = new Language { Name = "JavaScript" };
                Languages.Add(l10);

                Language l11 = new Language { Name = "Objective-C" };
                Languages.Add(l11);

                Language l12 = new Language { Name = "Objective-C++" };
                Languages.Add(l12);

                Language l13 = new Language { Name = "PHP" };
                Languages.Add(l13);

                Language l14 = new Language { Name = "Python" };
                Languages.Add(l14);

                Language l15 = new Language { Name = "Ruby" };
                Languages.Add(l15);

                Language l16 = new Language { Name = "Rust" };
                Languages.Add(l16);

                Language l17 = new Language { Name = "Shell" };
                Languages.Add(l17);

                Language l18 = new Language { Name = "Swift" };
                Languages.Add(l18);

                Language l19 = new Language { Name = "TypeScript" };
                Languages.Add(l19);

                Language l20 = new Language { Name = "Unspecified" };
                Languages.Add(l20);

                Language l21 = new Language { Name = "Vim script" };
                Languages.Add(l21);

                Language l;
      
                //loop through the list and see which (if any) need to be added
                foreach (Language lang in Languages)
                {
                    //see if the language already exists in the database
                    l = db.Languages.FirstOrDefault(x => x.Name == lang.Name);

                    //language was not found
                    if (l == null)
                    {
                        //Add the language
                        db.Languages.Add(lang);
                        db.SaveChanges();
                        intLanguagesAdded += 1;
                    }

                }
            }
            catch
            {
                String msg = "Languages Added: " + intLanguagesAdded.ToString();
                throw new InvalidOperationException(msg);
            }

        }
    }
}
