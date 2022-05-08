![GitHub forks](https://img.shields.io/github/forks/brianreville/OSDataAccessLibrary?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/brianreville/OSDataAccessLibrary?style=for-the-badge)
![GitHub stars](https://img.shields.io/github/stars/brianreville/OSDataAccessLibrary?style=for-the-badge)
![GitHub contributors](https://img.shields.io/github/contributors/brianreville/OSDataAccessLibrary?style=for-the-badge)

![GitHub license](https://img.shields.io/github/license/brianreville/OSBookReviewTests?style=for-the-badge)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/brianreville/OSBookReviewTests?style=for-the-badge)

# OSDataAccessLibrary
OS Data Access Library

## Key Components

A Data Access Library built using the light weight ORM Dapper created by Stack-Overflow.  
For the purposed of the project the following was implmented :  

1. Data Services
2. Data Models

### Data Services

For this 3 Class and assocaiated Interfacaes was Implemented
1. SQL Data Acesss (In the case of our project the DB of Choice was an Azure MQ Sql Server Database) The connection string for this called comes from the appconfig file of the project that is utilising the data access library.This class can be copeid and altered with a an inteface implementaion for a variety of database by changing some minor immplemenations and references to the type of database desired. Thus allowing the project to grow an evolve, For the purpose of the project the following crud operations were implmented
      1. Load A List of Generic Type T allowing for the passing of dynamic parameters utilising stored procedures
      2. Get a single Object of Generic Type T allowing for the passing of dynamic parameters utilsing stored procedures
      3. Saving Data Using a inline sql statement, passing a list of paraeteres
      4. Saving Data using a stored procedure with an object as a parameters for the stored procedure.
      5. Delete of Data using a stored procedure allowing for the passing of a list of parameteres.
      6. Returning a string value based on inline sql statement, allowing for the passing of a list of parameters
      7. Returning a intger value based on inline sql statement, allowing for the passing of a list of parameters
      8. Returnning an non modelled dataset using an inline sql statement , allowing for the passing of a list of parameters
2. Login Data A class for handling secure login to the application and the database using passwords and authentication.
3. Data Access Class which consists of 8 methods for handling CRUD operations outlined the SQL Data Access class and being implemented by the use of dependency injection in the various parts of the other projects

### Data Models
For this project the various models expected to be returned from stored procuders were defined in the model folder. These models can be added or altered as required to suit the program.

## Main Repository for Open Source College Project is the Web API Project

### Web API 
Please see associated repository
[OS Book Review Web API  ](https://github.com/brianreville/OSBookReviewWebAPI)

### .Net MAUI

Please see associated repository
[OS Book Review .NET MAUI App ](https://github.com/brianreville/OSBookReviewMAUI)


### Web API Unit Testing Project
Please see associated repository
[OS Book Review Tests  ](https://github.com/brianreville/OSBookReviewTests)
