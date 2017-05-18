# CandidatesAPI
Web API 2 and ASP MVC 

Don't forget to launch the API before launching the MVC App

----------------------------------------- GENERAL ---------------------------------------------
This Project use Entity Framework Code First :
Be sure to change the Connection String and create the associated empty database.

It's possible to Mock the DAL to avoid creating the database to do so just change :
in ReedAPI.Controllers.CandidatesController

private readonly ICanditateServices candidatesServices = BLLFactory.CreateCandidateServices();
by
private readonly ICanditateServices candidatesServices = BLLFactory.MockCandidateServices();

For more informations don't hesitate to contact me :
tavernierjf@gmail.com / +33663871038

----------------------------------------- TO DO ---------------------------------------------
I haven't had the time to do everything i wanted to do, here some of the missing point :
- Authentication
- Ninjec IoC
- Log/Error Management
- Research by Name/Skills
