using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Assignment_2
{
    public class Program
    {

        private static char ch;
        public static void Main(string[] args)
        {
           
            do
            {


                Console.WriteLine("1-Add\n2-Delete\n3-Update");
                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {

                    case 1:
                        add();
                        break;
                    case 2:
                        delete();
                        break;

                    case 3:

                        update();
                        break;

                }


                Console.WriteLine("Do you want to Continue...(y/n)");
                 Program.ch = Convert.ToChar(Console.ReadLine());

            } while (Program.ch=='y');
               
           

    }

        private static void update()
        {
            Console.WriteLine("1-Update in Product\n2-Update in Update\n");
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {


                case 1:
                    var db1 = new UpdateAndProduct();
                    Console.WriteLine("Enter Id..");

                    var Id1 = Convert.ToInt32(Console.ReadLine());
                    var update1 = (from s in db1.products_1
                                  where s.Pid == Id1
                                  select s).FirstOrDefault();
                    if (update1 != null)
                    {
                        Console.WriteLine("Enter Field to be updated..Name,Description Or Home Url..");
                        Console.WriteLine("Enter new Name..");
                        var Name = Console.ReadLine();
                        Console.WriteLine("Enter New Description..");
                        var Description = Console.ReadLine();
                        Console.WriteLine("Enter new HomepageUrl..");
                        var HomeUrl = Console.ReadLine();
                        if (Name != "")
                            update1.Pname = Name;
                        if (Description != "")
                            update1.Pdescription = Description;

                        
                         if (HomeUrl != "")
                            update1.HomePageUrl = HomeUrl;

                        
                           
                        db1.products_1.Update(update1);
                        db1.SaveChanges();

                   }
                    else
                    {
                        Console.WriteLine("No Record found...");
                    }


                   break;

                case 2:
                    var db = new UpdateAndProduct();
                    Console.WriteLine("Enter Product Id ...");

                    var Id = Convert.ToInt32(Console.ReadLine());
                   
                    
                     var update = (from s in db.updates
                                      where s.Pid == Id
                                      select s).FirstOrDefault();


                     
                    if (update != null)
                    {
                        Console.WriteLine("Enter Field to be updated..Name,Description..");
                        Console.WriteLine("Enter new Name..");
                        var Name = Console.ReadLine();
                        Console.WriteLine("Enter New Description..");
                        var Description = Console.ReadLine();
                        Console.WriteLine("Enter new HomepageUrl..");
                        var HomeUrl = Console.ReadLine();
                        if (Name != "")
                            update.Name = Name;
                        if (Description != "")
                            update.Description = Description;
                        
                        db.updates.Update(update);
                        db.SaveChanges();

                    }
                    else
                    {
                        Console.WriteLine("No Record found...");
                    }

                    break;


            }
           
       }

        private static void delete()
        {
            Console.WriteLine("1-Delete in Product\n2-Delete in Update\n");
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {

                case 1:
                    var db = new UpdateAndProduct();
                    Console.WriteLine("Enter the Id to be deleted..");

                    var id = Convert.ToInt32(Console.ReadLine());
                    var del = (from s in db.products_1
                               where s.Pid == id
                               select s).FirstOrDefault();


                    if (del != null)
                    {
                        db.products_1.Attach(del);
                        db.products_1.Remove(del);
                        db.SaveChanges();


                    }
                    else
                    {

                        Console.WriteLine("ooops You cant delete...");

                    }


                    break;






                case 2:
                    var db1 = new UpdateAndProduct();
                    Console.WriteLine("Enter the Id to be deleted..");

                    var id1 = Convert.ToInt32(Console.ReadLine());
                    var del1 = (from s in db1.updates
                                where s.Id == id1
                                select s).FirstOrDefault();


                    if (del1 != null)
                    {
                        db1.updates.Attach(del1);
                        db1.updates.Remove(del1);
                        db1.SaveChanges();


                    }
                    else
                    {

                        Console.WriteLine("ooops You cant delete...");

                    }


                    break;
            }

        }

        private static void add()
        {


            Console.WriteLine("1-Add in Product\n2-Add in Update\n");
            var input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {

                case 1:
                    var db1 = new UpdateAndProduct();
                    Console.WriteLine("Enter the name..");
                    var name1 = Console.ReadLine();
                    Console.WriteLine("Enter Description..");
                    var description1 = Console.ReadLine();
                    Console.WriteLine("Enter HomePage Url..");
                    var Url1 = Console.ReadLine();


                    db1.products_1.Add(new ProductModel { Pname = name1, Pdescription = description1, HomePageUrl = Url1, });
                    db1.SaveChanges(); 

                    break;
                case 2:

                    var db = new UpdateAndProduct();
                    Console.WriteLine("Enter the name..");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter Description..");
                    var description = Console.ReadLine();
                   
                    Console.WriteLine("Enter Product Id..");
                    var pid = Convert.ToInt32(Console.ReadLine());


                    db.updates.Add(new UpdateModel {

                        Name = name,

                        Description = description,

                        Pid = pid });
                    db.SaveChanges();
             
                   break;



            }
            
          

        }
    }
}
