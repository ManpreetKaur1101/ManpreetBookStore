24 october 2023
Name:Manpreet Kaur
Student-Id:0812152

part-1
started My Assignment 2 and name it as ManpreetBookStore.I also add my readme file and working on it.
I create my git repository and make it public.Afterthat, i run my app in the browser and it is working well.
afterthat,i register a mail in my application as shown in class and apply migration and shows hellomessage.

 after that i run my app and it gives me waring then inside properties i put ssl port into comment and run my app again and its working. 

 In strtup.cs i make changes as required for assignment.afterthat , I examine other files as required for assignment and i also commint it on in main.
now I am done with part 1 assignment 2.

part-2
(Debugging) 
i start debugging and add breakpiont and and run my app and its is  working upto where i applu breakpoint afterthat it need continue click to do further process.

part-3 (BootsWatch)
part third is about bootswatch in which i download bootstrap minty format style from bootswatch.com  and then
under wwwroot/css i change the name of the previous file and add the downloaded file inside it.
moreover,i made changes in layout.cshtml as required according to the tutorail.

Inside my loginPartial.cshtml i made changes and run my app in the browser.wow..... it's looking nice as a ux experience.

30 OCTOBER 2023
i updated my layout.cshtml by adding css and javascript links in it.Moreover,i added dropdown menu in that and its working.......
afterthat , i changed the name of my dropdown menu to content management.


Moreover,I created my ManpreetBooks.DataAccess class libarary.
also i created other two projects libraries that are ManpreetBooks.Models and ManpreetBooks.Utility.
I droped data folder in the ManpreetBooks.DatabaseAccess and deleted the original folder.

further,I Inastallted microsoft entity frameworkcore.relational and sqlserver packages.and i deleted migration folder.
I downlod the Identity.EntityFramework core.

I updated the namespace in ManpreetBooks.DataAccess and delete the all the default class1 file in all the project.
afterthat i moved model folder in ManpreetBooks.Model and delete the original one as mentioned.

I added project references of .DataAccess and Models and then rename the model folder to ViewModels and changed its namespace.
i delete the model folder and add previous in ManpreetBooks.Model.


In startup.cs i made changes as required by using using statement.
afterthat i run my app to see the errors in my code.



it shows error then i fix the error and remove using statement and correct the references as .Model.ViewModels.errorviewmodels.
afeter fixing all the error i run my browser again and it is working ..

in my utility folder i added a class name SD.cs.afterthat i modify the properties of the class.then i added project references from the main project. ManpreetBookStore.

In dataaccess i added the references.
Inside area i added area with name customer.and make change in routes in startup.cs.

i moved hpmecontroller.cs to area>customer and folder and delete data and models.
afterthat i edit homecontroler.cs and define controler in the customer area.
i moveviews home and modify the homecontroller.

i copied viewimport and viewstart to customer area.and also modify viewstart.cshtml.
Added admin inside area and added import and cs/html file in it also deleted controller folder and completed my assignment 2 first part.


3 november 2023 (Assignment2-part2)
firstly i build the solution to check the errors . afterthat i review appsetting.json and modify the database and save it.

I use nugetpackage manager consoole to add migrations.then it shows error then i change the correct default project dataaccess and run it again..
afterthat i run it again and its working.
I ADDED add-migration AddDefaultIdentityMigrationand set defaultproject ManpreetBooks.DataAccess and its running.
i updated my database.


afterthat i review my tables........done for today...

Date:6 november 2023

i added a new class file category.cs on Models project and also added migration add-migration AddCategoryToDb  to the PM console and build succeded.
in the apllicationdbcontext.cs i updated using statement and ee run add migrations and resolve duplication error rerun application.

i also added category to the applicatuiondbcontext.

(add repository)
I added a new folder inside dataacces with name Repository and inside that i added a new folder name IRepository.alos,under the same repository i added a new item with name IRepository.cs.
afterthat, i modified IRepository.cs and add crud operations and using statements..
afterthat, i used method of crud to get item from db,list of category,add objects,and remove objects....

i updated my Repository.cs in my assignment......

12:54 

inside repository i created categoryrepository.cs and ICategoryRepository and i modify the categoryRepository.cs by using statement also 
i modify ICatgory repository interface and review it for errors and impltement CategoryRepository.cs updated. and completed modifications..and fix the bugs  and commits to github..

Moreover,i added a new interfece in IRepository Folder with name ISO_Call.cs.

afterthat,i include new methods and install NuPackages for dapper and also implement this with the new class in (ISP_Call.cs) repository folder.
I added a new class SP_cs in repository folder and i selected using statement and implement ISP_Call interface and also addede connections to the database by adding using statements.

I updated the SP_call.cs as shown in tutorail..

I added new interface of name IUnitOfWork and UnitOfWork and make changes as required and make changes in startup.cs..

i fix all errors and run my browser and its working....


i added a new MVC controller empty inside area/admin and name as categorycontroller.cs and modify it.
afterthat i add new folder in area/view and added index view folder and modify categoryindex viewtxt file and run app its working.....
